using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {

	/// <summary>
	/// Used to store an array of bytes in one location,
	/// but pass smaller sections of that data without copying
	/// the data.
	/// </summary>
	public class ByteArray : IEnumerable<byte> {
		
		private byte[] source; //The source data that is being referenced.
		private int index; //The starting index of the selected data.

		/// <summary>
		/// The length of the array. The source data array may be larger.
		/// </summary>
		public int Length { get; private set; }

		/// <summary>
		/// Create a new empty array. This will create a new byte array in memory.
		/// </summary>
		public ByteArray() {
			source = new byte[0];
			index = 0;
			Length = 0;
		}

		/// <summary>
		/// Create a new array based on existing data. Null is accepted, but not advised.
		/// </summary>
		/// <param name="array"></param>
		public ByteArray(byte[] array) {
			source = array;
			index = 0;
			Length = (array != null) ? array.Length : 0;
		}

		/// <summary>
		/// Create a new array based on existing data.
		/// The index indicates where in the data the subset will start.
		/// Length is adjusted accordingly.
		/// 
		/// A null source will throw an exception.
		/// A negative index or index greater than the length will throw an exception.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="index"></param>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public ByteArray(byte[] array, int index) {
			source = array ?? throw new NullReferenceException("Given array is null, index is invalid.");
			if (index >= array.Length) throw new IndexOutOfRangeException();
			Length = array.Length - index;
		}

		/// <summary>
		/// Create a new array subset with the given source, start index, and desired length.
		///
		/// A null source will throw an excception.
		/// A negative index or index greater than the length will throw an exception.
		/// A negative length or length that extends beyond the source array will throw an exception.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="index"></param>
		/// <param name="length"></param>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public ByteArray(byte[] array, int index, int length) {
			source = array ?? throw new NullReferenceException("Given array is null, index is invalid.");
			if ((index < 0) || (index >= array.Length)) throw new IndexOutOfRangeException("Given index is outside of the range of the array.");
			this.index = index;
			if ((length < 0) || ((index + length) > array.Length)) throw new IndexOutOfRangeException("Given length is outside of the range of the array.");
			Length = length;
		}

		/// <summary>
		/// Create a sub-array at the given offset from the current array.
		/// Length is adjusted accordingly.
		/// 
		/// Offset must be positive and not extend beyond the array's length.
		/// </summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public ByteArray Sub(int offset) {
			return new ByteArray(source, index + offset, Length - 1);
		}

		/// <summary>
		/// Create a sub-array at the given offset from the current array and with the given length.
		/// 
		/// The offset must be positive and not extend beyond the array's length.
		/// The length must be positive and not extend beyond the array's bounds.
		/// </summary>
		/// <param name="offset"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public ByteArray Sub(int offset, int length) {
			if ((offset + length) > Length) throw new IndexOutOfRangeException("The new length extends beyond the original size.");
			return new ByteArray(source, index + offset, length);
		}

		/// <summary>
		/// Returns a sub-array whose size is smaller than the current length.
		/// The array start does not change, simply the length.
		/// 
		/// The length must be positive and not extend beyond the array's length.
		/// </summary>
		/// <param name="newLength"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public ByteArray Resize(int newLength) {
			if (newLength > Length) throw new ArgumentOutOfRangeException("Length must be less than or equal to the current length.");
			return new ByteArray(source, index, newLength);
		}

		/// <summary>
		/// Creates a copy of the array, copying the source data as well.
		/// Only the selected data from the source is copied. i.e. data outside of the bounds is not copied.
		/// </summary>
		/// <returns></returns>
		public ByteArray Copy() {
			if (source == null) return new ByteArray();
			byte[] data = new byte[Length];
			Array.Copy(source, index, data, 0, Length);
			return new ByteArray(data);
		}

		public void CopyTo(byte[] dest) {
			Array.Copy(source, index, dest, 0, Length);
		}

		public void CopyTo(byte[] dest, int startIndex) {
			Array.Copy(source, index, dest, startIndex, Length);
		}

		public void CopyTo(byte[] dest, int startIndex, int length) {
			Array.Copy(source, index, dest, startIndex, length);
		}

		/// <summary>
		/// Returns the sub-array data in a byte array form.
		/// The original data is copied.
		/// </summary>
		/// <returns></returns>
		public byte[] ToArray() {
			if (source == null) return null;
			if (Length == 0) return new byte[0];
			else {
				byte[] array = new byte[Length];
				Array.Copy(source, index, array, 0, Length);
				return array;
			}
		}

		/// <summary>
		/// Gets or sets the data at the given index.
		/// 
		/// An index outside of the array bounds will throw an exception.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public byte this[int i] {
			get {
				if ((i < 0) || (i >= Length))
					throw new IndexOutOfRangeException("Index is outside the bounds of the array.");
				return source[index + i];
			}

			set {
				if ((i < 0) || (i >= Length))
					throw new IndexOutOfRangeException("Index is outside the bounds of the array.");
				source[index + i] = value;
			}
		}

		/// <summary>
		/// Increment the start index of the sub-array. Same as calling <see cref="Sub(int)"/>
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public static ByteArray operator +(ByteArray arr, int offset) {
			return arr.Sub(offset);
		}

		/// <summary>
		/// Increment the start index of the sub-array. Same as calling <see cref="Sub(int)"/>
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		/// <exception cref="NullReferenceException"></exception>
		/// <exception cref="IndexOutOfRangeException"></exception>
		public static ByteArray operator ++(ByteArray arr) {
			return arr.Sub(1);
		}

		
		public static bool operator ==(ByteArray array1, ByteArray array2) {
			if ((object)array1 == null) {
				return ((object)array2 == null);
			} else if ((object)array2 == null) return false;
			else {
				return (array1.source == null) == (array2.source == null);
			}
		}

		// this is second one '!='
		public static bool operator !=(ByteArray array1, ByteArray array2) {
			if ((object)array1 == null) {
				return ((object)array2 != null);
			} else if ((object)array2 != null) return false;
			else {
				return (array1.source == null) != (array2.source == null);
			}
		}
		//public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

		public IEnumerator<byte> GetEnumerator() {
			return new ByteArrayEnumerator(source, index, Length);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return new ByteArrayEnumerator(source, index, Length);
		}

		public override bool Equals(object obj) {
			return base.Equals(obj);
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		private class ByteArrayEnumerator : IEnumerator<byte> {
			private byte[] source;
			private int ogIndex;
			private int ogLength;
			private int index;
			private int length;

			public byte Current { get; private set; }

			object IEnumerator.Current => Current;

			public ByteArrayEnumerator(byte[] source, int index, int length) {
				this.source = source;
				this.index = this.ogIndex = index - 1;
				this.length = this.ogLength = length;
			}

			public void Dispose() {
				
			}

			public bool MoveNext() {
				if(length-- > 0) {
					Current = source[++index];
					return true;
				} else {
					return false;
				}
			}

			public void Reset() {
				index = ogIndex;
				length = ogLength;
			}
		}
	}
}
