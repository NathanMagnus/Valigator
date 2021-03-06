﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public interface IStateValidator<TValue>
	{
		Data<TValue> Data { get; }

		IStateDescriptor GetDescriptor();

		IValueDescriptor[] GetImplicitValueDescriptors();

		Result<TValue, ValidationError[]> Validate(object model, bool isSet, TValue value);
	}
}
