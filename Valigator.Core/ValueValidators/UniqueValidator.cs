﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct UniqueValidator<TValue> : IValueValidator<TValue[]>
	{
		IValueDescriptor IValueValidator<TValue[]>.GetDescriptor()
			=> new UniqueDescriptor();

		bool IValueValidator<TValue[]>.IsValid(TValue[] value)
			=> value.Length <= 1 ? true : !GetDuplicates(value).Any();

		ValidationError IValueValidator<TValue[]>.GetError(TValue[] value, bool inverted)
			=> new ValidationError(nameof(UniqueValidator<TValue>), (this as IValueValidator<TValue[]>).GetDescriptor());

		private IEnumerable<TValue> GetDuplicates(TValue[] value)
		{
			var set = new HashSet<TValue>();

			foreach (var item in value)
			{
				if (!set.Add(item))
					yield return item;
			}
		}
	}
}
