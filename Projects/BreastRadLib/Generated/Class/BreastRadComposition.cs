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
	public class BreastRadComposition : CompositionBase, IHeaderFragment
	{
		//+ Fields
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSBuildMemberListBase.cs:33
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSBuildMemberListBase.cs:33
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // CSBuildMemberListBase.cs:33
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // CSBuildMemberListBase.cs:33
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSBuildMemberListBase.cs:33
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:33
		//- Fields

		//+ Properties
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // CSDefineBase.cs:182
			this.Report = new Report_Accessor(doc);                                                                                                  // CSBuildMemberListBase.cs:36
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSBuildMemberListBase.cs:36
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // CSBuildMemberListBase.cs:36
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // CSBuildMemberListBase.cs:36
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSBuildMemberListBase.cs:36
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:36
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
			if (this.Report.Validate(sb) == false) retVal = false;                                                                                   // CSBuildMemberListBase.cs:45
			if (this.Impressions.Validate(sb) == false) retVal = false;                                                                              // CSBuildMemberListBase.cs:45
			if (this.FindingsRightBreast.Validate(sb) == false) retVal = false;                                                                      // CSBuildMemberListBase.cs:45
			if (this.FindingsLeftBreast.Validate(sb) == false) retVal = false;                                                                       // CSBuildMemberListBase.cs:45
			if (this.RelatedResources.Validate(sb) == false) retVal = false;                                                                         // CSBuildMemberListBase.cs:45
			if (this.Recommendations.Validate(sb) == false) retVal = false;                                                                          // CSBuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			ClearSection();                                                                                                                          // CSBuildMemberListSection.cs:181
			this.WriteSection(this.Report);                                                                                                          // CSBuildMemberListBase.cs:39
			this.WriteSection(this.Impressions);                                                                                                     // CSBuildMemberListBase.cs:39
			this.WriteSection(this.FindingsRightBreast);                                                                                             // CSBuildMemberListBase.cs:39
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // CSBuildMemberListBase.cs:39
			this.WriteSection(this.RelatedResources);                                                                                                // CSBuildMemberListBase.cs:39
			this.WriteSection(this.Recommendations);                                                                                                 // CSBuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadSection(this.Report);                                                                                                           // CSBuildMemberListBase.cs:42
			this.ReadSection(this.Impressions);                                                                                                      // CSBuildMemberListBase.cs:42
			this.ReadSection(this.FindingsRightBreast);                                                                                              // CSBuildMemberListBase.cs:42
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // CSBuildMemberListBase.cs:42
			this.ReadSection(this.RelatedResources);                                                                                                 // CSBuildMemberListBase.cs:42
			this.ReadSection(this.Recommendations);                                                                                                  // CSBuildMemberListBase.cs:42
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
