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
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// Report
		/// Access fhir element 'Composition.section:report'
		/// </summary>
		public MReport Report { get ; protected set; }                                                                                            // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// Impressions
		/// Access fhir element 'Composition.section:impressions'
		/// </summary>
		public MImpressions Impressions { get ; protected set; }                                                                                  // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// FindingsRightBreast
		/// Access fhir element 'Composition.section:findingsRightBreast'
		/// </summary>
		public MFindingsRightBreast FindingsRightBreast { get ; protected set; }                                                                  // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// FindingsLeftBreast
		/// Access fhir element 'Composition.section:findingsLeftBreast'
		/// </summary>
		public MFindingsLeftBreast FindingsLeftBreast { get ; protected set; }                                                                    // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// RelatedResources
		/// Access fhir element 'Composition.section:relatedResources'
		/// </summary>
		public MRelatedResources RelatedResources { get ; protected set; }                                                                        // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberSection.cs, Line 226
		// BuildMemberBase.cs:377
		/// <summary>
		/// Recommendations
		/// Access fhir element 'Composition.section:recommendations'
		/// </summary>
		public MRecommendations Recommendations { get ; protected set; }                                                                          // BuildMemberBase.cs:381
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
			// Called from BuildMemberSection.cs, Line 226
			this.Report = new MReport(1, 1);                                                                                                         // BuildMemberBase.cs:360
			// Called from BuildMemberSection.cs, Line 226
			this.Impressions = new MImpressions(0, 0);                                                                                               // BuildMemberBase.cs:360
			// Called from BuildMemberSection.cs, Line 226
			this.FindingsRightBreast = new MFindingsRightBreast(0, 0);                                                                               // BuildMemberBase.cs:360
			// Called from BuildMemberSection.cs, Line 226
			this.FindingsLeftBreast = new MFindingsLeftBreast(0, 0);                                                                                 // BuildMemberBase.cs:360
			// Called from BuildMemberSection.cs, Line 226
			this.RelatedResources = new MRelatedResources(0, 0);                                                                                     // BuildMemberBase.cs:360
			// Called from BuildMemberSection.cs, Line 226
			this.Recommendations = new MRecommendations(0, 0);                                                                                       // BuildMemberBase.cs:360
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
			this.WriteSections(this.Doc);                                                                                                            // BuildMemberSection.cs:174
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
			this.ReadSections(this.Doc);                                                                                                             // BuildMemberSection.cs:183
			//- !ReadSections
			//- ReadCode
		}

		//+ Methods
		                                                                                                                                          // BuildMemberSection.cs:138
		//+ !Sections
		                                                                                                                                          // BuildMemberSection.cs:141
		// BuildMemberSection.cs:142
		/// <summary>
		/// Read all values from resource into this instance
		/// </summary>
		private void ReadSections(BreastRadiologyDocument doc)                                                                                    // BuildMemberSection.cs:145
		{                                                                                                                                         // BuildMemberSection.cs:146
		    List<Composition.SectionComponent> items = this.Resource.GetValue<Composition.SectionComponent>("section").ToList();                  // BuildMemberSection.cs:147
		    //+ ReadSections
		    this.Report.Read(this.Doc, items);                                                                                                    // BuildMemberSection.cs:95
		    this.Impressions.Read(this.Doc, items);                                                                                               // BuildMemberSection.cs:95
		    this.FindingsRightBreast.Read(this.Doc, items);                                                                                       // BuildMemberSection.cs:95
		    this.FindingsLeftBreast.Read(this.Doc, items);                                                                                        // BuildMemberSection.cs:95
		    this.RelatedResources.Read(this.Doc, items);                                                                                          // BuildMemberSection.cs:95
		    this.Recommendations.Read(this.Doc, items);                                                                                           // BuildMemberSection.cs:95
		    //- ReadSections
		}                                                                                                                                         // BuildMemberSection.cs:149
		                                                                                                                                          // BuildMemberSection.cs:151
		// BuildMemberSection.cs:152
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteSections(BreastRadiologyDocument doc)                                                                                   // BuildMemberSection.cs:155
		{                                                                                                                                         // BuildMemberSection.cs:156
		    List<Composition.SectionComponent> items = new List<Composition.SectionComponent>();                                                  // BuildMemberSection.cs:157
		    //+ WriteSections
		    items.AddRange(this.Report.Write(this.Doc));                                                                                          // BuildMemberSection.cs:118
		    items.AddRange(this.Impressions.Write(this.Doc));                                                                                     // BuildMemberSection.cs:118
		    items.AddRange(this.FindingsRightBreast.Write(this.Doc));                                                                             // BuildMemberSection.cs:118
		    items.AddRange(this.FindingsLeftBreast.Write(this.Doc));                                                                              // BuildMemberSection.cs:118
		    items.AddRange(this.RelatedResources.Write(this.Doc));                                                                                // BuildMemberSection.cs:118
		    items.AddRange(this.Recommendations.Write(this.Doc));                                                                                 // BuildMemberSection.cs:118
		    //- WriteSections
		    this.Resource.SetValue("section", items);                                                                                             // BuildMemberSection.cs:159
		}                                                                                                                                         // BuildMemberSection.cs:160
		//- !Sections
		//- Methods
	}
}
