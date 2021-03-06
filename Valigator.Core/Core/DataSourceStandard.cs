﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct DataSourceStandard<TStateValidator, TValueValidatorOne, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		internal TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, TValueValidatorOne, TValue>(_stateValidator, _valueValidatorOne));

		public DataSourceStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal DataSourceInverted<TStateValidator, TValueValidatorOne, TValue> InvertOne()
			=> new DataSourceInverted<TStateValidator, TValueValidatorOne, TValue>(_stateValidator, _valueValidatorOne);

		internal DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<TValue>(DataSourceStandard<TStateValidator, TValueValidatorOne, TValue> dataSource)
			=> dataSource.Data;
	}
}
