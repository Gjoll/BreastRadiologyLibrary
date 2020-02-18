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
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSDefineComposition.cs:225
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSDefineComposition.cs:225
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSDefineComposition.cs:225
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSDefineComposition.cs:225
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public BreastRadComposition() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadComposition(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Composition());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Composition resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // CSDefineBase.cs:208
			this.Report = new Report_Accessor(doc);                                                                                                  // CSDefineComposition.cs:228
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSDefineComposition.cs:228
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSDefineComposition.cs:228
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSDefineComposition.cs:228
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		//- WriteCodeStart
		//+ WriteCode
		ClearSection();                                                                                                                           // CSDefineComposition.cs:185
		this.WriteSection(this.Report);                                                                                                           // CSDefineComposition.cs:236
		this.WriteSection(this.Impressions);                                                                                                      // CSDefineComposition.cs:236
		this.WriteSection(this.RelatedResources);                                                                                                 // CSDefineComposition.cs:236
		this.WriteSection(this.Recommendations);                                                                                                  // CSDefineComposition.cs:236
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadSection(this.Report);                                                                                                            // CSDefineComposition.cs:240
		this.ReadSection(this.Impressions);                                                                                                       // CSDefineComposition.cs:240
		this.ReadSection(this.RelatedResources);                                                                                                  // CSDefineComposition.cs:240
		this.ReadSection(this.Recommendations);                                                                                                   // CSDefineComposition.cs:240
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
