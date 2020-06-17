﻿using System.Collections.Generic;
using Eshava.Transition.Interfaces;

namespace Eshava.Test.Transition.Models
{
	public class AdditionalPropertyDataRoot : IEmpty
	{
		public string Beta { get; set; }
		public AdditionalPropertyDataOne Gamma { get; set; }
		public IEnumerable<string> Epsilon { get; set; }
		public IEnumerable<AdditionalPropertyDataTwo> Zeta { get; set; }
		public bool IsEmpty => false;

		public string AttributeBeta { get; set; }
		public string AttributeGamma { get; set; }
		public string AttributeEpsilons { get; set; }
		public string AttributeEpsilon { get; set; }
		public string AttributeZetas { get; set; }
		public string AttributeZeta { get; set; }
		public string AttributeRoot { get; set; }
	}
}