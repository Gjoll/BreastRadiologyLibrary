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
	public class BreastBodyLocationExtension : ExtensionBase, IBreastBodyLocationExtension
	{
		//+ Properties
		public Quadrant_Accessor Quadrant { get ; protected set; }                                                                                // BuildMemberListBase.cs:33
		public Region_Accessor Region { get ; protected set; }                                                                                    // BuildMemberListBase.cs:33
		public ClockDirection_Accessor ClockDirection { get ; protected set; }                                                                    // BuildMemberListBase.cs:33
		public Depth_Accessor Depth { get ; protected set; }                                                                                      // BuildMemberListBase.cs:33
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public BreastBodyLocationExtension() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BreastBodyLocationExtension(BreastRadiologyDocument doc, Extension resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastBodyLocationExtension");                                // DefineBase.cs:189
			this.Quadrant = new Quadrant_Accessor(doc);                                                                                              // BuildMemberListBase.cs:36
			this.Region = new Region_Accessor(doc);                                                                                                  // BuildMemberListBase.cs:36
			this.ClockDirection = new ClockDirection_Accessor(doc);                                                                                  // BuildMemberListBase.cs:36
			this.Depth = new Depth_Accessor(doc);                                                                                                    // BuildMemberListBase.cs:36
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
			if (this.Quadrant.Validate(sb) == false) retVal = false;                                                                                 // BuildMemberListBase.cs:45
			if (this.Region.Validate(sb) == false) retVal = false;                                                                                   // BuildMemberListBase.cs:45
			if (this.ClockDirection.Validate(sb) == false) retVal = false;                                                                           // BuildMemberListBase.cs:45
			if (this.Depth.Validate(sb) == false) retVal = false;                                                                                    // BuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearExtensions();                                                                                                                  // BuildMemberListExtensionValue.cs:27
			//- WriteCodeStart
			//+ WriteCode
			this.WriteExtension(this.Quadrant);                                                                                                      // BuildMemberListBase.cs:39
			this.WriteExtension(this.Region);                                                                                                        // BuildMemberListBase.cs:39
			this.WriteExtension(this.ClockDirection);                                                                                                // BuildMemberListBase.cs:39
			this.WriteExtension(this.Depth);                                                                                                         // BuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadExtension(this.Quadrant);                                                                                                       // BuildMemberListBase.cs:42
			this.ReadExtension(this.Region);                                                                                                         // BuildMemberListBase.cs:42
			this.ReadExtension(this.ClockDirection);                                                                                                 // BuildMemberListBase.cs:42
			this.ReadExtension(this.Depth);                                                                                                          // BuildMemberListBase.cs:42
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
