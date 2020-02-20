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
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSBuildMemberListBase.cs:40
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSBuildMemberListBase.cs:40
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // CSBuildMemberListBase.cs:40
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // CSBuildMemberListBase.cs:40
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSBuildMemberListBase.cs:40
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
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
			this.Report = new Report_Accessor(doc);                                                                                                  // CSBuildMemberListBase.cs:43
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSBuildMemberListBase.cs:43
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // CSBuildMemberListBase.cs:43
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // CSBuildMemberListBase.cs:43
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSBuildMemberListBase.cs:43
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			//- Constructor
		}

		public override void Validate()
		{
			base.Validate();
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			ClearSection();                                                                                                                          // CSBuildMemberListSection.cs:182
			this.WriteSection(this.Report);                                                                                                          // CSBuildMemberListBase.cs:46
			this.WriteSection(this.Impressions);                                                                                                     // CSBuildMemberListBase.cs:46
			this.WriteSection(this.FindingsRightBreast);                                                                                             // CSBuildMemberListBase.cs:46
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // CSBuildMemberListBase.cs:46
			this.WriteSection(this.RelatedResources);                                                                                                // CSBuildMemberListBase.cs:46
			this.WriteSection(this.Recommendations);                                                                                                 // CSBuildMemberListBase.cs:46
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadSection(this.Report);                                                                                                           // CSBuildMemberListBase.cs:49
			this.ReadSection(this.Impressions);                                                                                                      // CSBuildMemberListBase.cs:49
			this.ReadSection(this.FindingsRightBreast);                                                                                              // CSBuildMemberListBase.cs:49
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // CSBuildMemberListBase.cs:49
			this.ReadSection(this.RelatedResources);                                                                                                 // CSBuildMemberListBase.cs:49
			this.ReadSection(this.Recommendations);                                                                                                  // CSBuildMemberListBase.cs:49
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
