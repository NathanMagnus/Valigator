﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Newtonsoft.FluentValidation;
using Xunit;

namespace Newtonsoft.FluentValidations.Tests
{
	public class DataTests
	{
		[Fact]
		public void ValueNotInitialized()
		=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Value);

		[Fact]
		public void WithValueNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).WithValue(5));

		[Fact]
		public void VerifyNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Verify(new object()));

		[Fact]
		public void ValueNotSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.Value);

		[Fact]
		public void ValueSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Value);

		[Fact]
		public void ValueSetAndVerified()
			=> Data.Required<int>().Data.WithValue(5).Verify(new object()).AssureSuccess().Value.Should().Be(5);

		[Fact]
		public void ValueAlreadySet()
			=> Assert.Throws<DataAlreadySetException>(() => Data.Required<int>().Data.WithValue(5).WithValue(5));

		[Fact]
		public void ValueAlreadyVerified()
			=> Assert.Throws<DataAlreadyVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Verify(new object()).AssureSuccess().Verify(new object()));
	}
}
