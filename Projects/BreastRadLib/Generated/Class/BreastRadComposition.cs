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
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSBuildMemberListSection.cs:226
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSBuildMemberListSection.cs:226
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // CSBuildMemberListSection.cs:226
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // CSBuildMemberListSection.cs:226
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSBuildMemberListSection.cs:226
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSBuildMemberListSection.cs:226
		//- Fields

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
			this.Report = new Report_Accessor(doc);                                                                                                  // CSBuildMemberListSection.cs:229
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSBuildMemberListSection.cs:229
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // CSBuildMemberListSection.cs:229
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // CSBuildMemberListSection.cs:229
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSBuildMemberListSection.cs:229
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSBuildMemberListSection.cs:229
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			ClearSection();                                                                                                                          // CSBuildMemberListSection.cs:186
			this.WriteSection(this.Report);                                                                                                          // CSBuildMemberListSection.cs:237
			this.WriteSection(this.Impressions);                                                                                                     // CSBuildMemberListSection.cs:237
			this.WriteSection(this.FindingsRightBreast);                                                                                             // CSBuildMemberListSection.cs:237
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // CSBuildMemberListSection.cs:237
			this.WriteSection(this.RelatedResources);                                                                                                // CSBuildMemberListSection.cs:237
			this.WriteSection(this.Recommendations);                                                                                                 // CSBuildMemberListSection.cs:237
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadSection(this.Report);                                                                                                           // CSBuildMemberListSection.cs:241
			this.ReadSection(this.Impressions);                                                                                                      // CSBuildMemberListSection.cs:241
			this.ReadSection(this.FindingsRightBreast);                                                                                              // CSBuildMemberListSection.cs:241
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // CSBuildMemberListSection.cs:241
			this.ReadSection(this.RelatedResources);                                                                                                 // CSBuildMemberListSection.cs:241
			this.ReadSection(this.Recommendations);                                                                                                  // CSBuildMemberListSection.cs:241
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
