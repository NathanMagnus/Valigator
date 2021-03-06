﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree));

		public NullableDataSourceStandardStandardStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		internal NullableDataSourceStandardStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> InvertThree()
			=> new NullableDataSourceStandardStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public static implicit operator Data<Option<TValue>>(NullableDataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> dataSource)
			=> dataSource.Data;
	}
}
