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
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// Report
		/// Access fhir element 'Composition.section:report'
		/// </summary>
		public ReportContainer Report { get ; protected set; }                                                                                    // BuildMemberBase.cs:336
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// Impressions
		/// Access fhir element 'Composition.section:impressions'
		/// </summary>
		public ImpressionsContainer Impressions { get ; protected set; }                                                                          // BuildMemberBase.cs:336
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// FindingsRightBreast
		/// Access fhir element 'Composition.section:findingsRightBreast'
		/// </summary>
		public FindingsRightBreastContainer FindingsRightBreast { get ; protected set; }                                                          // BuildMemberBase.cs:336
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// FindingsLeftBreast
		/// Access fhir element 'Composition.section:findingsLeftBreast'
		/// </summary>
		public FindingsLeftBreastContainer FindingsLeftBreast { get ; protected set; }                                                            // BuildMemberBase.cs:336
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// RelatedResources
		/// Access fhir element 'Composition.section:relatedResources'
		/// </summary>
		public RelatedResourcesContainer RelatedResources { get ; protected set; }                                                                // BuildMemberBase.cs:336
		                                                                                                                                          // BuildMemberBase.cs:331
		/// <summary>
		/// Recommendations
		/// Access fhir element 'Composition.section:recommendations'
		/// </summary>
		public RecommendationsContainer Recommendations { get ; protected set; }                                                                  // BuildMemberBase.cs:336
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // DefineBase.cs:220
			this.Report = new ReportContainer(1, 1);                                                                                                 // BuildMemberBase.cs:320
			this.Impressions = new ImpressionsContainer(0, 0);                                                                                       // BuildMemberBase.cs:320
			this.FindingsRightBreast = new FindingsRightBreastContainer(0, 0);                                                                       // BuildMemberBase.cs:320
			this.FindingsLeftBreast = new FindingsLeftBreastContainer(0, 0);                                                                         // BuildMemberBase.cs:320
			this.RelatedResources = new RelatedResourcesContainer(0, 0);                                                                             // BuildMemberBase.cs:320
			this.Recommendations = new RecommendationsContainer(0, 0);                                                                               // BuildMemberBase.cs:320
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
			this.WriteSections(this.Doc);                                                                                                            // BuildMemberSection.cs:153
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
			this.ReadSections(this.Doc);                                                                                                             // BuildMemberSection.cs:162
			//- !ReadSections
			//- ReadCode
		}

		//+ Methods
		                                                                                                                                          // BuildMemberSection.cs:117
		//+ !Sections
		                                                                                                                                          // BuildMemberSection.cs:120
		/// <summary>
		/// Read all values from resource into this instance
		/// </summary>
		private void ReadSections(BreastRadiologyDocument doc)                                                                                    // BuildMemberSection.cs:124
		{                                                                                                                                         // BuildMemberSection.cs:125
		    List<Composition.SectionComponent> items = this.Resource.GetValue<Composition.SectionComponent>("section").ToList();                  // BuildMemberSection.cs:126
		    //+ ReadSections
		    this.Report.Read(this.Doc, items);                                                                                                    // BuildMemberSection.cs:71
		    this.Impressions.Read(this.Doc, items);                                                                                               // BuildMemberSection.cs:71
		    this.FindingsRightBreast.Read(this.Doc, items);                                                                                       // BuildMemberSection.cs:71
		    this.FindingsLeftBreast.Read(this.Doc, items);                                                                                        // BuildMemberSection.cs:71
		    this.RelatedResources.Read(this.Doc, items);                                                                                          // BuildMemberSection.cs:71
		    this.Recommendations.Read(this.Doc, items);                                                                                           // BuildMemberSection.cs:71
		    //- ReadSections
		}                                                                                                                                         // BuildMemberSection.cs:128
		                                                                                                                                          // BuildMemberSection.cs:130
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteSections(BreastRadiologyDocument doc)                                                                                   // BuildMemberSection.cs:134
		{                                                                                                                                         // BuildMemberSection.cs:135
		    List<Composition.SectionComponent> items = new List<Composition.SectionComponent>();                                                  // BuildMemberSection.cs:136
		    //+ WriteSections
		    items.AddRange(this.Report.Write(this.Doc));                                                                                          // BuildMemberSection.cs:97
		    items.AddRange(this.Impressions.Write(this.Doc));                                                                                     // BuildMemberSection.cs:97
		    items.AddRange(this.FindingsRightBreast.Write(this.Doc));                                                                             // BuildMemberSection.cs:97
		    items.AddRange(this.FindingsLeftBreast.Write(this.Doc));                                                                              // BuildMemberSection.cs:97
		    items.AddRange(this.RelatedResources.Write(this.Doc));                                                                                // BuildMemberSection.cs:97
		    items.AddRange(this.Recommendations.Write(this.Doc));                                                                                 // BuildMemberSection.cs:97
		    //- WriteSections
		    this.Resource.SetValue("section", items);                                                                                             // BuildMemberSection.cs:138
		}                                                                                                                                         // BuildMemberSection.cs:139
		//- !Sections
		//- Methods
	}
}
