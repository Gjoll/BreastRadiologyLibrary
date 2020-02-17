using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BodyDistanceFromExtensionLocal;
//+Usings
//-Usings

namespace BreastRadLib
{
	public class BodyDistanceFromExtension : ExtensionBase, IHeaderFragment
	{
		//+ Fields
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public BodyDistanceFromExtension() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BodyDistanceFromExtension(BreastRadiologyDocument doc, Extension resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BodyDistanceFromExtension(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Extension());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Extension resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		//- WriteCodeStart
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
