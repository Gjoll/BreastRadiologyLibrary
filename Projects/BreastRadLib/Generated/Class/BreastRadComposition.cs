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
		public Report_Accessor Report { get ; protected set; }                                                                                    // CSDefineComposition.cs:226
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // CSDefineComposition.cs:226
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // CSDefineComposition.cs:226
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // CSDefineComposition.cs:226
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // CSDefineComposition.cs:226
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // CSDefineComposition.cs:226
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
		public void Init(BreastRadiologyDocument doc, Composition resource = null)
		{
			if (resource == null)
				resource = new Composition();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // CSDefineBase.cs:208
			this.Report = new Report_Accessor(doc);                                                                                                  // CSDefineComposition.cs:229
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // CSDefineComposition.cs:229
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // CSDefineComposition.cs:229
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // CSDefineComposition.cs:229
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // CSDefineComposition.cs:229
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // CSDefineComposition.cs:229
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			ClearSection();                                                                                                                          // CSDefineComposition.cs:186
			this.WriteSection(this.Report);                                                                                                          // CSDefineComposition.cs:237
			this.WriteSection(this.Impressions);                                                                                                     // CSDefineComposition.cs:237
			this.WriteSection(this.FindingsRightBreast);                                                                                             // CSDefineComposition.cs:237
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // CSDefineComposition.cs:237
			this.WriteSection(this.RelatedResources);                                                                                                // CSDefineComposition.cs:237
			this.WriteSection(this.Recommendations);                                                                                                 // CSDefineComposition.cs:237
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadSection(this.Report);                                                                                                           // CSDefineComposition.cs:241
			this.ReadSection(this.Impressions);                                                                                                      // CSDefineComposition.cs:241
			this.ReadSection(this.FindingsRightBreast);                                                                                              // CSDefineComposition.cs:241
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // CSDefineComposition.cs:241
			this.ReadSection(this.RelatedResources);                                                                                                 // CSDefineComposition.cs:241
			this.ReadSection(this.Recommendations);                                                                                                  // CSDefineComposition.cs:241
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
