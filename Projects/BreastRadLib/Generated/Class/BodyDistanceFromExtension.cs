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
using BreastRadLib.HeaderFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class BodyDistanceFromExtension : ExtensionBase, IHeaderFragment
	{
		//+ Fields
		public LandMark_Accessor LandMark { get ; protected set; }                                                                                // CSBuildMemberListBase.cs:33
		public DistanceFromLandMark_Accessor DistanceFromLandMark { get ; protected set; }                                                        // CSBuildMemberListBase.cs:33
		//- Fields

		//+ Properties
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public BodyDistanceFromExtension() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BodyDistanceFromExtension(BreastRadiologyDocument doc, Extension resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BodyDistanceFromExtension(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BodyDistanceFromExtension");                                  // CSDefineBase.cs:182
			this.LandMark = new LandMark_Accessor(doc);                                                                                              // CSBuildMemberListBase.cs:36
			this.DistanceFromLandMark = new DistanceFromLandMark_Accessor(doc);                                                                      // CSBuildMemberListBase.cs:36
			//- Constructor
		}

		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			if (this.LandMark.Validate(sb) == false) retVal = false;                                                                                 // CSBuildMemberListBase.cs:45
			if (this.DistanceFromLandMark.Validate(sb) == false) retVal = false;                                                                     // CSBuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearExtensions();                                                                                                                  // CSBuildMemberListExtensionValue.cs:27
			//- WriteCodeStart
			//+ WriteCode
			this.WriteExtension(this.LandMark);                                                                                                      // CSBuildMemberListBase.cs:39
			this.WriteExtension(this.DistanceFromLandMark);                                                                                          // CSBuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadExtension(this.LandMark);                                                                                                       // CSBuildMemberListBase.cs:42
			this.ReadExtension(this.DistanceFromLandMark);                                                                                           // CSBuildMemberListBase.cs:42
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
