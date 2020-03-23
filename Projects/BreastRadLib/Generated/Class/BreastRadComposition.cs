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
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// Report
		/// Access fhir element 'Composition.section:report'
		/// </summary>
		public MReport Report { get ; protected set; }                                                                                            // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// Impressions
		/// Access fhir element 'Composition.section:impressions'
		/// </summary>
		public MImpressions Impressions { get ; protected set; }                                                                                  // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// FindingsRightBreast
		/// Access fhir element 'Composition.section:findingsRightBreast'
		/// </summary>
		public MFindingsRightBreast FindingsRightBreast { get ; protected set; }                                                                  // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// FindingsLeftBreast
		/// Access fhir element 'Composition.section:findingsLeftBreast'
		/// </summary>
		public MFindingsLeftBreast FindingsLeftBreast { get ; protected set; }                                                                    // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// RelatedResources
		/// Access fhir element 'Composition.section:relatedResources'
		/// </summary>
		public MRelatedResources RelatedResources { get ; protected set; }                                                                        // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberSection.cs, Line 225
		// BuildMemberBase.cs:392
		/// <summary>
		/// Recommendations
		/// Access fhir element 'Composition.section:recommendations'
		/// </summary>
		public MRecommendations Recommendations { get ; protected set; }                                                                          // BuildMemberBase.cs:396
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
			// Called from BuildMemberSection.cs, Line 225
			this.Report = new MReport(1, 1);                                                                                                         // BuildMemberBase.cs:375
			// Called from BuildMemberSection.cs, Line 225
			this.Impressions = new MImpressions(0, -1);                                                                                              // BuildMemberBase.cs:375
			// Called from BuildMemberSection.cs, Line 225
			this.FindingsRightBreast = new MFindingsRightBreast(0, 1);                                                                               // BuildMemberBase.cs:375
			// Called from BuildMemberSection.cs, Line 225
			this.FindingsLeftBreast = new MFindingsLeftBreast(0, 1);                                                                                 // BuildMemberBase.cs:375
			// Called from BuildMemberSection.cs, Line 225
			this.RelatedResources = new MRelatedResources(0, -1);                                                                                    // BuildMemberBase.cs:375
			// Called from BuildMemberSection.cs, Line 225
			this.Recommendations = new MRecommendations(0, -1);                                                                                      // BuildMemberBase.cs:375
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
			this.WriteSections(this.Doc);                                                                                                            // BuildMemberSection.cs:173
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
			this.ReadSections(this.Doc);                                                                                                             // BuildMemberSection.cs:182
			//- !ReadSections
			//- ReadCode
		}

		//+ Methods
		                                                                                                                                          // BuildMemberSection.cs:137
		//+ !Sections
		                                                                                                                                          // BuildMemberSection.cs:140
		// BuildMemberSection.cs:141
		/// <summary>
		/// Read all values from resource into this instance
		/// </summary>
		private void ReadSections(BreastRadiologyDocument doc)                                                                                    // BuildMemberSection.cs:144
		{                                                                                                                                         // BuildMemberSection.cs:145
		    List<Composition.SectionComponent> items = this.Resource.GetValue<Composition.SectionComponent>("section").ToList();                  // BuildMemberSection.cs:146
		    //+ ReadSections
		    this.Report.Read(this.Doc, items);                                                                                                    // BuildMemberSection.cs:94
		    this.Impressions.Read(this.Doc, items);                                                                                               // BuildMemberSection.cs:94
		    this.FindingsRightBreast.Read(this.Doc, items);                                                                                       // BuildMemberSection.cs:94
		    this.FindingsLeftBreast.Read(this.Doc, items);                                                                                        // BuildMemberSection.cs:94
		    this.RelatedResources.Read(this.Doc, items);                                                                                          // BuildMemberSection.cs:94
		    this.Recommendations.Read(this.Doc, items);                                                                                           // BuildMemberSection.cs:94
		    //- ReadSections
		}                                                                                                                                         // BuildMemberSection.cs:148
		                                                                                                                                          // BuildMemberSection.cs:150
		// BuildMemberSection.cs:151
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteSections(BreastRadiologyDocument doc)                                                                                   // BuildMemberSection.cs:154
		{                                                                                                                                         // BuildMemberSection.cs:155
		    List<Composition.SectionComponent> items = new List<Composition.SectionComponent>();                                                  // BuildMemberSection.cs:156
		    //+ WriteSections
		    items.AddRange(this.Report.Write(this.Doc));                                                                                          // BuildMemberSection.cs:117
		    items.AddRange(this.Impressions.Write(this.Doc));                                                                                     // BuildMemberSection.cs:117
		    items.AddRange(this.FindingsRightBreast.Write(this.Doc));                                                                             // BuildMemberSection.cs:117
		    items.AddRange(this.FindingsLeftBreast.Write(this.Doc));                                                                              // BuildMemberSection.cs:117
		    items.AddRange(this.RelatedResources.Write(this.Doc));                                                                                // BuildMemberSection.cs:117
		    items.AddRange(this.Recommendations.Write(this.Doc));                                                                                 // BuildMemberSection.cs:117
		    //- WriteSections
		    this.Resource.SetValue("section", items);                                                                                             // BuildMemberSection.cs:158
		}                                                                                                                                         // BuildMemberSection.cs:159
		//- !Sections
		//- Methods
	}
}
