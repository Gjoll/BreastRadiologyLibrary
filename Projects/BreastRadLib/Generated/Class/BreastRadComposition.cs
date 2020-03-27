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
	/// <summary>
	/// Class BreastRadComposition.
	/// This class is automatically generated.
	/// </summary>
	public class BreastRadComposition : CompositionBase, IBreastRadComposition
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// Report
		/// Access fhir element 'Composition.section:report'
		/// </summary>
		public MReport Report { get ; protected set; }                                                                                            // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// Impressions
		/// Access fhir element 'Composition.section:impressions'
		/// </summary>
		public MImpressions Impressions { get ; protected set; }                                                                                  // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// FindingsRightBreast
		/// Access fhir element 'Composition.section:findingsRightBreast'
		/// </summary>
		public MFindingsRightBreast FindingsRightBreast { get ; protected set; }                                                                  // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// FindingsLeftBreast
		/// Access fhir element 'Composition.section:findingsLeftBreast'
		/// </summary>
		public MFindingsLeftBreast FindingsLeftBreast { get ; protected set; }                                                                    // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// RelatedResources
		/// Access fhir element 'Composition.section:relatedResources'
		/// </summary>
		public MRelatedResources RelatedResources { get ; protected set; }                                                                        // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// Recommendations
		/// Access fhir element 'Composition.section:recommendations'
		/// </summary>
		public MRecommendations Recommendations { get ; protected set; }                                                                          // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberSection.cs, Line 222
		// BuildMemberBase.cs:395
		/// <summary>
		/// Admin
		/// Access fhir element 'Composition.section:admin'
		/// </summary>
		public MAdmin Admin { get ; protected set; }                                                                                              // BuildMemberBase.cs:399
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public BreastRadComposition() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // DefineBase.cs:238
			// Called from BuildMemberSection.cs, Line 222
			this.Report = new MReport(1, 1);                                                                                                         // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.Impressions = new MImpressions(0, -1);                                                                                              // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.FindingsRightBreast = new MFindingsRightBreast(0, 1);                                                                               // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.FindingsLeftBreast = new MFindingsLeftBreast(0, 1);                                                                                 // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.RelatedResources = new MRelatedResources(0, -1);                                                                                    // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.Recommendations = new MRecommendations(0, -1);                                                                                      // BuildMemberBase.cs:378
			// Called from BuildMemberSection.cs, Line 222
			this.Admin = new MAdmin(0, -1);                                                                                                          // BuildMemberBase.cs:378
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
			//- WriteCodeStart
			//+ WriteCode
			//+ !WriteSections
			this.WriteSections(this.Doc);                                                                                                            // BuildMemberSection.cs:170
			//- !WriteSections
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
			//+ !ReadSections
			this.ReadSections(this.Doc);                                                                                                             // BuildMemberSection.cs:179
			//- !ReadSections
			//- ReadCode
		}

		//+ Methods
		                                                                                                                                          // BuildMemberSection.cs:134
		//+ !Sections
		                                                                                                                                          // BuildMemberSection.cs:137
		// BuildMemberSection.cs:138
		/// <summary>
		/// Read all values from resource into this instance
		/// </summary>
		private void ReadSections(BreastRadiologyDocument doc)                                                                                    // BuildMemberSection.cs:141
		{                                                                                                                                         // BuildMemberSection.cs:142
		    List<Composition.SectionComponent> items = this.Resource.GetValue<Composition.SectionComponent>("section").ToList();                  // BuildMemberSection.cs:143
		    //+ ReadSections
		    this.Report.Read(this.Doc, items);                                                                                                    // BuildMemberSection.cs:91
		    this.Impressions.Read(this.Doc, items);                                                                                               // BuildMemberSection.cs:91
		    this.FindingsRightBreast.Read(this.Doc, items);                                                                                       // BuildMemberSection.cs:91
		    this.FindingsLeftBreast.Read(this.Doc, items);                                                                                        // BuildMemberSection.cs:91
		    this.RelatedResources.Read(this.Doc, items);                                                                                          // BuildMemberSection.cs:91
		    this.Recommendations.Read(this.Doc, items);                                                                                           // BuildMemberSection.cs:91
		    this.Admin.Read(this.Doc, items);                                                                                                     // BuildMemberSection.cs:91
		    //- ReadSections
		}                                                                                                                                         // BuildMemberSection.cs:145
		                                                                                                                                          // BuildMemberSection.cs:147
		// BuildMemberSection.cs:148
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteSections(BreastRadiologyDocument doc)                                                                                   // BuildMemberSection.cs:151
		{                                                                                                                                         // BuildMemberSection.cs:152
		    List<Composition.SectionComponent> items = new List<Composition.SectionComponent>();                                                  // BuildMemberSection.cs:153
		    //+ WriteSections
		    items.AddRange(this.Report.Write(this.Doc));                                                                                          // BuildMemberSection.cs:114
		    items.AddRange(this.Impressions.Write(this.Doc));                                                                                     // BuildMemberSection.cs:114
		    items.AddRange(this.FindingsRightBreast.Write(this.Doc));                                                                             // BuildMemberSection.cs:114
		    items.AddRange(this.FindingsLeftBreast.Write(this.Doc));                                                                              // BuildMemberSection.cs:114
		    items.AddRange(this.RelatedResources.Write(this.Doc));                                                                                // BuildMemberSection.cs:114
		    items.AddRange(this.Recommendations.Write(this.Doc));                                                                                 // BuildMemberSection.cs:114
		    items.AddRange(this.Admin.Write(this.Doc));                                                                                           // BuildMemberSection.cs:114
		    //- WriteSections
		    this.Resource.SetValue("section", items);                                                                                             // BuildMemberSection.cs:155
		}                                                                                                                                         // BuildMemberSection.cs:156
		//- !Sections
		//- Methods
	}
}
