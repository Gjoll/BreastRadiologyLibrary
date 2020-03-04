using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ObservedFeatureVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		//+ Fields
		public static TCoding Code_ArchitecturalDistortion = new TCoding(ObservedFeatureCS.Code_ArchitecturalDistortion);                         // Builder.cs:353
		public static TCoding Code_AxillaryAdenopathy = new TCoding(ObservedFeatureCS.Code_AxillaryAdenopathy);                                   // Builder.cs:353
		public static TCoding Code_BiopsyClip = new TCoding(ObservedFeatureCS.Code_BiopsyClip);                                                   // Builder.cs:353
		public static TCoding Code_BiopsyClips = new TCoding(ObservedFeatureCS.Code_BiopsyClips);                                                 // Builder.cs:353
		public static TCoding Code_BrachytherapyTube = new TCoding(ObservedFeatureCS.Code_BrachytherapyTube);                                     // Builder.cs:353
		public static TCoding Code_ChestWallInvasion = new TCoding(ObservedFeatureCS.Code_ChestWallInvasion);                                     // Builder.cs:353
		public static TCoding Code_CooperDistorted = new TCoding(ObservedFeatureCS.Code_CooperDistorted);                                         // Builder.cs:353
		public static TCoding Code_CooperThickened = new TCoding(ObservedFeatureCS.Code_CooperThickened);                                         // Builder.cs:353
		public static TCoding Code_Edema = new TCoding(ObservedFeatureCS.Code_Edema);                                                             // Builder.cs:353
		public static TCoding Code_EdemaAdj = new TCoding(ObservedFeatureCS.Code_EdemaAdj);                                                       // Builder.cs:353
		public static TCoding Code_GoldSeed = new TCoding(ObservedFeatureCS.Code_GoldSeed);                                                       // Builder.cs:353
		public static TCoding Code_Hematoma = new TCoding(ObservedFeatureCS.Code_Hematoma);                                                       // Builder.cs:353
		public static TCoding Code_NippleRetraction = new TCoding(ObservedFeatureCS.Code_NippleRetraction);                                       // Builder.cs:353
		public static TCoding Code_NOChestWallInvasion = new TCoding(ObservedFeatureCS.Code_NOChestWallInvasion);                                 // Builder.cs:353
		public static TCoding Code_PectoralisMuscleInvasion = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvasion);                       // Builder.cs:353
		public static TCoding Code_PectoralisMuscleInvolvement = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvolvement);                 // Builder.cs:353
		public static TCoding Code_PectoralisMuscleTenting = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleTenting);                         // Builder.cs:353
		public static TCoding Code_PostSurgicalScar = new TCoding(ObservedFeatureCS.Code_PostSurgicalScar);                                       // Builder.cs:353
		public static TCoding Code_Seroma = new TCoding(ObservedFeatureCS.Code_Seroma);                                                           // Builder.cs:353
		public static TCoding Code_SkinInvolvement = new TCoding(ObservedFeatureCS.Code_SkinInvolvement);                                         // Builder.cs:353
		public static TCoding Code_SkinLesion = new TCoding(ObservedFeatureCS.Code_SkinLesion);                                                   // Builder.cs:353
		public static TCoding Code_SkinRetraction = new TCoding(ObservedFeatureCS.Code_SkinRetraction);                                           // Builder.cs:353
		public static TCoding Code_SkinThickening = new TCoding(ObservedFeatureCS.Code_SkinThickening);                                           // Builder.cs:353
		public static TCoding Code_SurgicalClip = new TCoding(ObservedFeatureCS.Code_SurgicalClip);                                               // Builder.cs:353
		public static TCoding Code_SurgicalClips = new TCoding(ObservedFeatureCS.Code_SurgicalClips);                                             // Builder.cs:353
		public static TCoding Code_TrabecularThickening = new TCoding(ObservedFeatureCS.Code_TrabecularThickening);                               // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_ArchitecturalDistortion;                                                                                            // Builder.cs:356
		    yield return Code_AxillaryAdenopathy;                                                                                                 // Builder.cs:356
		    yield return Code_BiopsyClip;                                                                                                         // Builder.cs:356
		    yield return Code_BiopsyClips;                                                                                                        // Builder.cs:356
		    yield return Code_BrachytherapyTube;                                                                                                  // Builder.cs:356
		    yield return Code_ChestWallInvasion;                                                                                                  // Builder.cs:356
		    yield return Code_CooperDistorted;                                                                                                    // Builder.cs:356
		    yield return Code_CooperThickened;                                                                                                    // Builder.cs:356
		    yield return Code_Edema;                                                                                                              // Builder.cs:356
		    yield return Code_EdemaAdj;                                                                                                           // Builder.cs:356
		    yield return Code_GoldSeed;                                                                                                           // Builder.cs:356
		    yield return Code_Hematoma;                                                                                                           // Builder.cs:356
		    yield return Code_NippleRetraction;                                                                                                   // Builder.cs:356
		    yield return Code_NOChestWallInvasion;                                                                                                // Builder.cs:356
		    yield return Code_PectoralisMuscleInvasion;                                                                                           // Builder.cs:356
		    yield return Code_PectoralisMuscleInvolvement;                                                                                        // Builder.cs:356
		    yield return Code_PectoralisMuscleTenting;                                                                                            // Builder.cs:356
		    yield return Code_PostSurgicalScar;                                                                                                   // Builder.cs:356
		    yield return Code_Seroma;                                                                                                             // Builder.cs:356
		    yield return Code_SkinInvolvement;                                                                                                    // Builder.cs:356
		    yield return Code_SkinLesion;                                                                                                         // Builder.cs:356
		    yield return Code_SkinRetraction;                                                                                                     // Builder.cs:356
		    yield return Code_SkinThickening;                                                                                                     // Builder.cs:356
		    yield return Code_SurgicalClip;                                                                                                       // Builder.cs:356
		    yield return Code_SurgicalClips;                                                                                                      // Builder.cs:356
		    yield return Code_TrabecularThickening;                                                                                               // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
