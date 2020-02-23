using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGAbnormalityAsymmetryTypeCS
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/MGAbnormalityAsymmetryTypeCS";                                  // Builder.cs:373
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Breast asymmetry refers to when one breast is a different size or shape than the
		/// other.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_Asymmetry = new Coding(System, "Asymmetry", "Asymmetry");                                                       // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Focal asymmetry is visible as a confined asymmetry with a similar shape on two views
		/// but does not fit the criteria of a mass: that is, it lacks convex outer borders and
		/// conspicuity.
		/// In contrast to global asymmetry, it occupies a volume of less than one quadrant of
		/// the breast and is of more concern.
		/// The frequency of finding focal asymmetry at screening mammography is less than 1%.
		/// [https://pubs.rsna.org/doi/10.1148/rg.e33]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_AsymmetryFocal = new Coding(System, "AsymmetryFocal", "Asymmetry focal");                                       // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Global asymmetry in breast tissue is a form of breast asymmetry where at least one
		/// quadrant of a breast has a larger amount of fibroglandular density than the corresponding
		/// area in the contralateral breast.
		/// 
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_AsymmetryGlobal = new Coding(System, "AsymmetryGlobal", "Asymmetry global");                                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// A developing asymmetry is a focal asymmetry that is new or increased in conspicuity
		/// compared with the previous mammogram.
		/// It is challenging to evaluate, as it often looks similar to fibroglandular tissue
		/// at mammography.
		/// A developing asymmetry should be viewed with suspicion because it is an uncommon
		/// manifestation of breast cancer.
		/// [https://pubs.rsna.org/doi/full/10.1148/rg.2016150123]
		/// Valid for the following modalities: MG.
		/// </summary>
		public static Coding Code_DevelopingAsymmetry = new Coding(System, "DevelopingAsymmetry", "Developing Asymmetry");                        // Builder.cs:399
		//- Fields
	}
}
