using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastRadCompositionLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class BreastRadComposition : CompositionBase, IBreastRadComposition
	{
		//+ Properties
		public Report_Accessor Report { get ; protected set; }                                                                                    // BuildMemberListBase.cs:33
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // BuildMemberListBase.cs:33
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // BuildMemberListBase.cs:33
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // BuildMemberListBase.cs:33
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // BuildMemberListBase.cs:33
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // BuildMemberListBase.cs:33
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public BreastRadComposition() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc)
		{
		this.Init(doc, new Composition());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Composition resource = (Composition) baseResource;
			if (resource == null)
				resource = new Composition();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // DefineBase.cs:189
			this.Report = new Report_Accessor(doc);                                                                                                  // BuildMemberListBase.cs:36
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // BuildMemberListBase.cs:36
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // BuildMemberListBase.cs:36
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // BuildMemberListBase.cs:36
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // BuildMemberListBase.cs:36
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // BuildMemberListBase.cs:36
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
			if (this.Report.Validate(sb) == false) retVal = false;                                                                                   // BuildMemberListBase.cs:45
			if (this.Impressions.Validate(sb) == false) retVal = false;                                                                              // BuildMemberListBase.cs:45
			if (this.FindingsRightBreast.Validate(sb) == false) retVal = false;                                                                      // BuildMemberListBase.cs:45
			if (this.FindingsLeftBreast.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListBase.cs:45
			if (this.RelatedResources.Validate(sb) == false) retVal = false;                                                                         // BuildMemberListBase.cs:45
			if (this.Recommendations.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			ClearSection();                                                                                                                          // BuildMemberListSection.cs:181
			this.WriteSection(this.Report);                                                                                                          // BuildMemberListBase.cs:39
			this.WriteSection(this.Impressions);                                                                                                     // BuildMemberListBase.cs:39
			this.WriteSection(this.FindingsRightBreast);                                                                                             // BuildMemberListBase.cs:39
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // BuildMemberListBase.cs:39
			this.WriteSection(this.RelatedResources);                                                                                                // BuildMemberListBase.cs:39
			this.WriteSection(this.Recommendations);                                                                                                 // BuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadSection(this.Report);                                                                                                           // BuildMemberListBase.cs:42
			this.ReadSection(this.Impressions);                                                                                                      // BuildMemberListBase.cs:42
			this.ReadSection(this.FindingsRightBreast);                                                                                              // BuildMemberListBase.cs:42
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // BuildMemberListBase.cs:42
			this.ReadSection(this.RelatedResources);                                                                                                 // BuildMemberListBase.cs:42
			this.ReadSection(this.Recommendations);                                                                                                  // BuildMemberListBase.cs:42
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
