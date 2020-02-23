using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ObservationComponentSliceCodes
	{
		//+ Fields
		const string System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                                // Builder.cs:373
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityCystType
		/// </summary>
		public static Coding Code_AbnormalityCystType = new Coding(System, "abnormalityCystType", "Component code for 'Cyst Type' slice");        // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityDuctType
		/// </summary>
		public static Coding Code_AbnormalityDuctType = new Coding(System, "abnormalityDuctType", "Component code for 'Duct Type' slice");        // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityFibroAdenomaType
		/// </summary>
		public static Coding Code_MgAbnormalityFibroAdenomaType = new Coding(System, "mgAbnormalityFibroAdenomaType", "Component code for 'FibroAdenoma Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityForeignObjectType
		/// </summary>
		public static Coding Code_AbnormalityForeignObjectType = new Coding(System, "abnormalityForeignObjectType", "Component code for 'Foreign Object Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityLymphNodeType
		/// </summary>
		public static Coding Code_AbnormalityLymphNodeType = new Coding(System, "abnormalityLymphNodeType", "Component code for 'Lymph Node Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice AbnormalityMassType
		/// </summary>
		public static Coding Code_AbnormalityMassType = new Coding(System, "abnormalityMassType", "Component code for 'Abnormality Mass Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice BiRads
		/// </summary>
		public static Coding Code_TargetBiRads = new Coding(System, "targetBiRads", "Component code for 'BiRads Code' slice");                    // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ConsistentWithValue
		/// </summary>
		public static Coding Code_ConsistentWithValue = new Coding(System, "consistentWithValue", "Component code for 'Consistent With Value' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ConsistentWithQualifier
		/// </summary>
		public static Coding Code_ConsistentWithQualifier = new Coding(System, "consistentWithQualifier", "Component code for 'Consistent With Qualifier' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice CorrespondsWith
		/// </summary>
		public static Coding Code_CorrespondsWith = new Coding(System, "correspondsWith", "Component code for 'Corresponds With' slice");         // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Previously Demonstrated By
		/// </summary>
		public static Coding Code_PrevDemBy = new Coding(System, "prevDemBy", "Component code for 'Previously Demonstrated By' slice");           // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Margin
		/// </summary>
		public static Coding Code_Margin = new Coding(System, "margin", "Component code for 'Margin' slice");                                     // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice MGDensity
		/// </summary>
		public static Coding Code_MgDensity = new Coding(System, "mgDensity", "Component code for 'MG Density' slice");                           // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Not Previously Seen
		/// </summary>
		public static Coding Code_NotPreviouslySeen = new Coding(System, "notPreviouslySeen", "Component code for 'Not Previously Seen' slice");  // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Observed Changes
		/// </summary>
		public static Coding Code_ObsChanges = new Coding(System, "obsChanges", "Component code for 'Observed Changes' slice");                   // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ObservedCount
		/// </summary>
		public static Coding Code_ObsCount = new Coding(System, "obsCount", "Component code for 'Observed Count' slice");                         // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ObservedDistribution
		/// </summary>
		public static Coding Code_ObsDistribution = new Coding(System, "obsDistribution", "Component code for 'Observed Distribution' slice");    // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ObservedSize
		/// </summary>
		public static Coding Code_ObsSize = new Coding(System, "obsSize", "Component code for 'Observed Size' slice");                            // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice ObservedFeatureType
		/// </summary>
		public static Coding Code_FeatureType = new Coding(System, "featureType", "Component code for 'Feature Type' slice");                     // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Orientation
		/// </summary>
		public static Coding Code_Orientation = new Coding(System, "orientation", "Component code for 'Orientation' slice");                      // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice Shape
		/// </summary>
		public static Coding Code_Shape = new Coding(System, "shape", "Component code for 'Shape' slice");                                        // Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice MGCodeAbnormalityAsymmetryType
		/// </summary>
		public static Coding Code_MgAbnormalityAsymmetryType = new Coding(System, "mgAbnormalityAsymmetryType", "Component code for 'Abnormality Asymmetry Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice MGCodeAbnormalityDensityType
		/// </summary>
		public static Coding Code_MgAbnormalityDensityType = new Coding(System, "mgAbnormalityDensityType", "Component code for 'Abnormality Density Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice MGCalcificationType
		/// </summary>
		public static Coding Code_MgCalcificationType = new Coding(System, "mgCalcificationType", "Component code for 'Calcification Type' slice");// Builder.cs:399
		                                                                                                                                          // Builder.cs:385
		/// <summary>
		/// Code to identify the component slice MGCalcificationDistribution
		/// </summary>
		public static Coding Code_MgCalcificationDistribution = new Coding(System, "mgCalcificationDistribution", "Component code for 'Distribution' slice");// Builder.cs:399
		//- Fields
	}
}
