// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// Response for Transform.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class TransformResponseDto : ServiceDto<TransformResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public TransformResponseDto()
		{
		}

		public JObject After { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(TransformResponseDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentObjects(After, other.After);
		}
	}
}
