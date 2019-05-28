﻿using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredNullableStateValidatorExtensions
	{
		public static NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<byte> requiredValidator, byte value)
			=> new NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredNullableStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredNullableStateValidator<sbyte> requiredValidator, sbyte value)
			=> new NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredNullableStateValidator<sbyte> requiredValidator, sbyte value)
			=> new NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredNullableStateValidator<sbyte> requiredValidator, sbyte value)
			=> new NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<sbyte> requiredValidator, sbyte value)
			=> new NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredNullableStateValidator<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredNullableStateValidator<short> requiredValidator, short value)
			=> new NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredNullableStateValidator<short> requiredValidator, short value)
			=> new NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredNullableStateValidator<short> requiredValidator, short value)
			=> new NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredNullableStateValidator<short> requiredValidator, short value)
			=> new NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredNullableStateValidator<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredNullableStateValidator<ushort> requiredValidator, ushort value)
			=> new NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredNullableStateValidator<ushort> requiredValidator, ushort value)
			=> new NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredNullableStateValidator<ushort> requiredValidator, ushort value)
			=> new NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ushort> requiredValidator, ushort value)
			=> new NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredNullableStateValidator<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredNullableStateValidator<int> requiredValidator, int value)
			=> new NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredNullableStateValidator<int> requiredValidator, int value)
			=> new NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredNullableStateValidator<int> requiredValidator, int value)
			=> new NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredNullableStateValidator<int> requiredValidator, int value)
			=> new NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredNullableStateValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredNullableStateValidator<uint> requiredValidator, uint value)
			=> new NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredNullableStateValidator<uint> requiredValidator, uint value)
			=> new NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredNullableStateValidator<uint> requiredValidator, uint value)
			=> new NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredNullableStateValidator<uint> requiredValidator, uint value)
			=> new NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredNullableStateValidator<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredNullableStateValidator<long> requiredValidator, long value)
			=> new NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredNullableStateValidator<long> requiredValidator, long value)
			=> new NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredNullableStateValidator<long> requiredValidator, long value)
			=> new NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredNullableStateValidator<long> requiredValidator, long value)
			=> new NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredNullableStateValidator<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredNullableStateValidator<ulong> requiredValidator, ulong value)
			=> new NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredNullableStateValidator<ulong> requiredValidator, ulong value)
			=> new NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredNullableStateValidator<ulong> requiredValidator, ulong value)
			=> new NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ulong> requiredValidator, ulong value)
			=> new NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredNullableStateValidator<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredNullableStateValidator<float> requiredValidator, float value)
			=> new NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredNullableStateValidator<float> requiredValidator, float value)
			=> new NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredNullableStateValidator<float> requiredValidator, float value)
			=> new NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredNullableStateValidator<float> requiredValidator, float value)
			=> new NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredNullableStateValidator<float> requiredValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredNullableStateValidator<double> requiredValidator, double value)
			=> new NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredNullableStateValidator<double> requiredValidator, double value)
			=> new NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredNullableStateValidator<double> requiredValidator, double value)
			=> new NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredNullableStateValidator<double> requiredValidator, double value)
			=> new NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredNullableStateValidator<double> requiredValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredNullableStateValidator<decimal> requiredValidator, decimal value)
			=> new NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, false, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredNullableStateValidator<decimal> requiredValidator, decimal value)
			=> new NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, true, null, false));

		public static NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredNullableStateValidator<decimal> requiredValidator, decimal value)
			=> new NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, false));

		public static NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredNullableStateValidator<decimal> requiredValidator, decimal value)
			=> new NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, true));

		public static NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredNullableStateValidator<decimal> requiredValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}