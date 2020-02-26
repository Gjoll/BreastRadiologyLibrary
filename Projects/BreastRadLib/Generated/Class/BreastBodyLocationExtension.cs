using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastBodyLocationExtensionLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class BreastBodyLocationExtension.
	/// This class is automatically generated.
	/// </summary>
	public class BreastBodyLocationExtension : ExtensionBase, IBreastBodyLocationExtension
	{
		//+ Properties
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public BreastBodyLocationExtension() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public BreastBodyLocationExtension(BreastRadiologyDocument doc, Extension resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public BreastBodyLocationExtension(BreastRadiologyDocument doc)
		{
			this.Init(doc, new Extension());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Extension resource = (Extension) baseResource;
			if (resource == null)
				resource = new Extension();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension");                                // DefineBase.cs:194
			//- Constructor
		}

		/// <summary>
		/// Validate object. Will return false if an error is detected. sb will contains text of error found.
		/// User must not call Init().
		/// </summary>
		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearExtensions();                                                                                                                  // BuildMemberListExtensionValue.cs:29
			this.ClearExtensions();                                                                                                                  // BuildMemberListExtensionValue.cs:29
			this.ClearExtensions();                                                                                                                  // BuildMemberListExtensionValue.cs:29
			this.ClearExtensions();                                                                                                                  // BuildMemberListExtensionValue.cs:29
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
