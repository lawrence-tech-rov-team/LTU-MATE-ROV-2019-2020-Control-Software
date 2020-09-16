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
			Length = array?.Length ?? 0;
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
			return new ByteArray(source, index + offset, Length - offset);
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

		private void Copy<T>(T[] source, int sourceIndex, T[] destination, int destinationIndex, int length) {
			for(int i = 0; i < length; i++) {
				destination[destinationIndex++] = source[sourceIndex++];
			}
		}

		/// <summary>
		/// Creates a copy of the array, copying the source data as well.
		/// Only the selected data from the source is copied. i.e. data outside of the bounds is not copied.
		/// </summary>
		/// <returns></returns>
		public ByteArray Copy() {
			if (source == null) return new ByteArray();
			byte[] data = new byte[Length];
			Copy(source, index, data, 0, Length);
			return new ByteArray(data);
		}

		public void CopyTo(byte[] dest) {
			Copy(source, index, dest, 0, Length);
		}

		public void CopyTo(byte[] dest, int startIndex) {
			Copy(source, index, dest, startIndex, Length);
		}

		public void CopyTo(byte[] dest, int startIndex, int length) {
			Copy(source, index, dest, startIndex, length);
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
				Copy(source, index, array, 0, Length);
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

		#region Parsing
		public bool ParseBool(int index, out bool result) {
			if((index >= 0) && ((index + sizeof(bool)) <= Length)) {
				try {
					result = BitConverter.ToBoolean(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(bool);
			return false;
		}
		public bool ParseBool(out bool result) {
			if (Length != sizeof(bool)) {
				result = default(bool);
				return false;
			} else return ParseBool(0, out result);
		}

		public bool ParseChar(int index, out char result) {
			if((index >= 0) && ((index + sizeof(char)) <= Length)) {
				try {
					result = BitConverter.ToChar(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(char);
			return false;
		}
		public bool ParseChar(out char result) {
			if (Length != sizeof(char)) {
				result = default(char);
				return false;
			} else return ParseChar(0, out result);
		}

		public bool ParseUInt8(int index, out byte result) {
			if((index >= 0) && (index < Length)) {
				result = source[this.index + index];
				return true;
			}

			result = default(byte);
			return false;
		}
		public bool ParseUInt8(out byte result) {
			if (Length != sizeof(byte)) {
				result = default(byte);
				return false;
			} else return ParseUInt8(0, out result);
		}

		public bool ParseInt8(int index, out sbyte result) {
			if((index >= 0) && (index < Length)) {
				result = (sbyte)source[this.index + index];
				return true;
			}

			result = default(sbyte);
			return false;
		}
		public bool ParseInt8(out sbyte result) {
			if (Length != sizeof(sbyte)) {
				result = default(sbyte);
				return false;
			} else return ParseInt8(0, out result);
		}

		public bool ParseUInt16(int index, out ushort result) {
			if((index >= 0) && ((index + sizeof(ushort)) <= Length)) {
				try {
					result = BitConverter.ToUInt16(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(ushort);
			return false;

		}
		public bool ParseUInt16(out ushort result) {
			if (Length != sizeof(ushort)) {
				result = default(ushort);
				return false;
			} else return ParseUInt16(0, out result);
		}

		public bool ParseInt16(int index, out short result) {
			if((index >= 0) && ((index + sizeof(short)) <= Length)) {
				try {
					result = BitConverter.ToInt16(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(short);
			return false;
		}
		public bool ParseInt16(out short result) {
			if (Length != sizeof(short)) {
				result = default(short);
				return false;
			} else return ParseInt16(0, out result);
		}

		public bool ParseUInt32(int index, out uint result) {
			if((index >= 0) && ((index + sizeof(uint)) <= Length)) {
				try {
					result = BitConverter.ToUInt32(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(uint);
			return false;
		}
		public bool ParseUInt32(out uint result) {
			if (Length != sizeof(uint)) {
				result = default(uint);
				return false;
			} else return ParseUInt32(out result);
		}

		public bool ParseInt32(int index, out int result) {
			if((index >= 0) && ((index + sizeof(int)) <= Length)) {
				try {
					result = BitConverter.ToInt32(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(int);
			return false;
		}
		public bool ParseInt32(out int result) {
			if (Length != sizeof(int)) {
				result = default(int);
				return false;
			} else return ParseInt32(0, out result);
		}

		public bool ParseUInt64(int index, out ulong result) {
			if((index >= 0) && ((index + sizeof(ulong)) <= Length)) {
				try {
					result = BitConverter.ToUInt64(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(ulong);
			return false;
		}
		public bool ParseUInt64(out ulong result) {
			if (Length != sizeof(ulong)) {
				result = default(ulong);
				return false;
			} else return ParseUInt64(0, out result);
		}

		public bool ParseSingle(int index, out float result) {
			if ((index >= 0) && ((index + sizeof(float)) <= Length)) {
				try {
					result = BitConverter.ToSingle(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(float);
			return false;
		}
		public bool ParseSingle(out float result) {
			if (Length != sizeof(float)) {
				result = default(float);
				return false;
			} else return ParseSingle(0, out result);
		}

		public bool ParseDouble(int index, out double result) {
			if((index >= 0) && ((index + sizeof(double)) <= Length)) {
				try {
					result = BitConverter.ToDouble(source, this.index + index);
					return true;
				} catch (Exception) { }
			}

			result = default(double);
			return false;
		}
		public bool ParseDouble(out double result) {
			if (Length != sizeof(double)) {
				result = default(double);
				return false;
			} else return ParseDouble(0, out result);
		}
		#endregion

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
