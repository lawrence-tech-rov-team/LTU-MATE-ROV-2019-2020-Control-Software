using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public class ByteArray {

		private byte[] source;
		private int index;
		public int Length { get; private set; }

		public ByteArray() {
			index = 0;
			Length = 0;
		}

		public ByteArray(byte[] array) {
			source = array;
			index = 0;
			Length = array.Length;
		}

		public ByteArray(byte[] array, int index) {
			source = array ?? throw new NullReferenceException("Given array is null, index is invalid.");
			if (index >= array.Length) throw new IndexOutOfRangeException();
			Length = array.Length - index;
		}

		public ByteArray(byte[] array, int index, int length) {
			source = array ?? throw new NullReferenceException("Given array is null, index is invalid.");
			if ((index < 0) || (index >= array.Length)) throw new IndexOutOfRangeException("Given index is outside of the range of the array.");
			this.index = index;
			if ((length < 0) || ((index + length) > array.Length)) throw new IndexOutOfRangeException("Given length is outside of the range of the array.");
			Length = length;
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

		public byte[] ToArray() {
			if (source == null) return null;
			if (Length == 0) return new byte[0];
			else {
				byte[] array = new byte[Length];
				Array.Copy(source, index, array, 0, Length);
				return array;
			}
		}

		public virtual byte this[int i] {
			get {
				if ((i < 0) || (i >= Length))
					throw new IndexOutOfRangeException("Index is outside the bounds of the array.");
				return source[i];
			}

			set {
				if ((i < 0) || (i >= Length))
					throw new IndexOutOfRangeException("Index is outside the bounds of the array.");
				source[i] = value;
			}
		}

		public static ByteArray operator +(ByteArray arr, int offset) {
			return new ByteArray(arr.source, arr.index + offset, arr.Length - 1);
		}

		public static ByteArray operator ++(ByteArray arr) {
			return new ByteArray(arr.source, arr.index + 1, arr.Length - 1);
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
		
	}
}
