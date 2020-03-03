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
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value Report
		/// </summary>
		public Report_Accessor Report { get ; protected set; }                                                                                    // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value Impressions
		/// </summary>
		public Impressions_Accessor Impressions { get ; protected set; }                                                                          // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value FindingsRightBreast
		/// </summary>
		public FindingsRightBreast_Accessor FindingsRightBreast { get ; protected set; }                                                          // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value FindingsLeftBreast
		/// </summary>
		public FindingsLeftBreast_Accessor FindingsLeftBreast { get ; protected set; }                                                            // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value RelatedResources
		/// </summary>
		public RelatedResources_Accessor RelatedResources { get ; protected set; }                                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Section value Recommendations
		/// </summary>
		public Recommendations_Accessor Recommendations { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // DefineBase.cs:215
			this.Report = new Report_Accessor(doc);                                                                                                  // BuildMemberListBase.cs:73
			this.Impressions = new Impressions_Accessor(doc);                                                                                        // BuildMemberListBase.cs:73
			this.FindingsRightBreast = new FindingsRightBreast_Accessor(doc);                                                                        // BuildMemberListBase.cs:73
			this.FindingsLeftBreast = new FindingsLeftBreast_Accessor(doc);                                                                          // BuildMemberListBase.cs:73
			this.RelatedResources = new RelatedResources_Accessor(doc);                                                                              // BuildMemberListBase.cs:73
			this.Recommendations = new Recommendations_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
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
			if (this.Report.Validate(sb) == false) retVal = false;                                                                                   // BuildMemberListBase.cs:82
			if (this.Impressions.Validate(sb) == false) retVal = false;                                                                              // BuildMemberListBase.cs:82
			if (this.FindingsRightBreast.Validate(sb) == false) retVal = false;                                                                      // BuildMemberListBase.cs:82
			if (this.FindingsLeftBreast.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListBase.cs:82
			if (this.RelatedResources.Validate(sb) == false) retVal = false;                                                                         // BuildMemberListBase.cs:82
			if (this.Recommendations.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
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
			ClearSection();                                                                                                                          // BuildMemberListSection.cs:188
			this.WriteSection(this.Report);                                                                                                          // BuildMemberListBase.cs:76
			this.WriteSection(this.Impressions);                                                                                                     // BuildMemberListBase.cs:76
			this.WriteSection(this.FindingsRightBreast);                                                                                             // BuildMemberListBase.cs:76
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // BuildMemberListBase.cs:76
			this.WriteSection(this.RelatedResources);                                                                                                // BuildMemberListBase.cs:76
			this.WriteSection(this.Recommendations);                                                                                                 // BuildMemberListBase.cs:76
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
			this.ReadSection(this.Report);                                                                                                           // BuildMemberListBase.cs:79
			this.ReadSection(this.Impressions);                                                                                                      // BuildMemberListBase.cs:79
			this.ReadSection(this.FindingsRightBreast);                                                                                              // BuildMemberListBase.cs:79
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // BuildMemberListBase.cs:79
			this.ReadSection(this.RelatedResources);                                                                                                 // BuildMemberListBase.cs:79
			this.ReadSection(this.Recommendations);                                                                                                  // BuildMemberListBase.cs:79
			//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
