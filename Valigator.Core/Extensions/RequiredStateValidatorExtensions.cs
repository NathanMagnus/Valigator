using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this RequiredStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> Length(this RequiredStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static DataSourceStandard<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static DataSourceStandard<RequiredStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this RequiredStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this RequiredStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this RequiredStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this RequiredStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this RequiredStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}