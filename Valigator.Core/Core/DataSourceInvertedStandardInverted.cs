﻿using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInvertedStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValueValidatorTwo, InvertValidator<TValueValidatorThree, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), _valueValidatorTwo, new InvertValidator<TValueValidatorThree, TValue>(_valueValidatorThree)));

		public DataSourceInvertedStandardInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public static implicit operator Data<TValue>(DataSourceInvertedStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> dataSource)
			=> dataSource.Data;
	}
}
