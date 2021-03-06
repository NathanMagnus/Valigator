using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedCollectionNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this DefaultedCollectionNullableStateValidator<TValue> source, Func<DefaultedCollectionNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this DefaultedCollectionNullableStateValidator<TValue> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> ItemCount<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, int? minimumItems = null, int? maximumItems = null)
			=> source.Add(new ItemCountValidator<TValue>(minimumItems, maximumItems));

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, UniqueValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> Unique<TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source)
			=> source.Add(new UniqueValidator<TValue>());

		public static NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]> source, Func<NullableDataSourceInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, CustomValidator<TValue[]>, TValue[]> Assert<TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, string description, Func<TValue[], bool> validator)
			=> source.Add(new CustomValidator<TValue[]>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedStandardStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceStandardInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceStandardInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]> Not<TValueValidator, TValue>(this NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]> source, Func<NullableDataSourceInvertedInverted<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValue[]>, NullableDataSourceInvertedInvertedStandard<DefaultedCollectionNullableStateValidator<TValue>, ItemCountValidator<TValue>, UniqueValidator<TValue>, TValueValidator, TValue[]>> validatorFactory)
			where TValueValidator : IValueValidator<TValue[]>
			=> validatorFactory.Invoke(source).InvertThree();
	}
}