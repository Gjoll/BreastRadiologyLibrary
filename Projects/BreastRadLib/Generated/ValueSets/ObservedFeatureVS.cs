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
		public static TCoding Code_ArchitecturalDistortion = new TCoding(ObservedFeatureCS.Code_ArchitecturalDistortion);                         // CSBuilder.cs:321
		public static TCoding Code_AxillaryAdenopathy = new TCoding(ObservedFeatureCS.Code_AxillaryAdenopathy);                                   // CSBuilder.cs:321
		public static TCoding Code_BiopsyClip = new TCoding(ObservedFeatureCS.Code_BiopsyClip);                                                   // CSBuilder.cs:321
		public static TCoding Code_BiopsyClips = new TCoding(ObservedFeatureCS.Code_BiopsyClips);                                                 // CSBuilder.cs:321
		public static TCoding Code_BrachytherapyTube = new TCoding(ObservedFeatureCS.Code_BrachytherapyTube);                                     // CSBuilder.cs:321
		public static TCoding Code_ChestWallInvasion = new TCoding(ObservedFeatureCS.Code_ChestWallInvasion);                                     // CSBuilder.cs:321
		public static TCoding Code_CooperDistorted = new TCoding(ObservedFeatureCS.Code_CooperDistorted);                                         // CSBuilder.cs:321
		public static TCoding Code_CooperThickened = new TCoding(ObservedFeatureCS.Code_CooperThickened);                                         // CSBuilder.cs:321
		public static TCoding Code_Edema = new TCoding(ObservedFeatureCS.Code_Edema);                                                             // CSBuilder.cs:321
		public static TCoding Code_EdemaAdj = new TCoding(ObservedFeatureCS.Code_EdemaAdj);                                                       // CSBuilder.cs:321
		public static TCoding Code_GoldSeed = new TCoding(ObservedFeatureCS.Code_GoldSeed);                                                       // CSBuilder.cs:321
		public static TCoding Code_Hematoma = new TCoding(ObservedFeatureCS.Code_Hematoma);                                                       // CSBuilder.cs:321
		public static TCoding Code_NippleRetraction = new TCoding(ObservedFeatureCS.Code_NippleRetraction);                                       // CSBuilder.cs:321
		public static TCoding Code_NOChestWallInvasion = new TCoding(ObservedFeatureCS.Code_NOChestWallInvasion);                                 // CSBuilder.cs:321
		public static TCoding Code_PectoralisMuscleInvasion = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvasion);                       // CSBuilder.cs:321
		public static TCoding Code_PectoralisMuscleInvolvement = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvolvement);                 // CSBuilder.cs:321
		public static TCoding Code_PectoralisMuscleTenting = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleTenting);                         // CSBuilder.cs:321
		public static TCoding Code_PostSurgicalScar = new TCoding(ObservedFeatureCS.Code_PostSurgicalScar);                                       // CSBuilder.cs:321
		public static TCoding Code_Seroma = new TCoding(ObservedFeatureCS.Code_Seroma);                                                           // CSBuilder.cs:321
		public static TCoding Code_SkinInvolvement = new TCoding(ObservedFeatureCS.Code_SkinInvolvement);                                         // CSBuilder.cs:321
		public static TCoding Code_SkinLesion = new TCoding(ObservedFeatureCS.Code_SkinLesion);                                                   // CSBuilder.cs:321
		public static TCoding Code_SkinRetraction = new TCoding(ObservedFeatureCS.Code_SkinRetraction);                                           // CSBuilder.cs:321
		public static TCoding Code_SkinThickening = new TCoding(ObservedFeatureCS.Code_SkinThickening);                                           // CSBuilder.cs:321
		public static TCoding Code_SurgicalClip = new TCoding(ObservedFeatureCS.Code_SurgicalClip);                                               // CSBuilder.cs:321
		public static TCoding Code_SurgicalClips = new TCoding(ObservedFeatureCS.Code_SurgicalClips);                                             // CSBuilder.cs:321
		public static TCoding Code_TrabecularThickening = new TCoding(ObservedFeatureCS.Code_TrabecularThickening);                               // CSBuilder.cs:321
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:306
		{                                                                                                                                         // CSBuilder.cs:307
		    yield return Code_ArchitecturalDistortion;                                                                                            // CSBuilder.cs:324
		    yield return Code_AxillaryAdenopathy;                                                                                                 // CSBuilder.cs:324
		    yield return Code_BiopsyClip;                                                                                                         // CSBuilder.cs:324
		    yield return Code_BiopsyClips;                                                                                                        // CSBuilder.cs:324
		    yield return Code_BrachytherapyTube;                                                                                                  // CSBuilder.cs:324
		    yield return Code_ChestWallInvasion;                                                                                                  // CSBuilder.cs:324
		    yield return Code_CooperDistorted;                                                                                                    // CSBuilder.cs:324
		    yield return Code_CooperThickened;                                                                                                    // CSBuilder.cs:324
		    yield return Code_Edema;                                                                                                              // CSBuilder.cs:324
		    yield return Code_EdemaAdj;                                                                                                           // CSBuilder.cs:324
		    yield return Code_GoldSeed;                                                                                                           // CSBuilder.cs:324
		    yield return Code_Hematoma;                                                                                                           // CSBuilder.cs:324
		    yield return Code_NippleRetraction;                                                                                                   // CSBuilder.cs:324
		    yield return Code_NOChestWallInvasion;                                                                                                // CSBuilder.cs:324
		    yield return Code_PectoralisMuscleInvasion;                                                                                           // CSBuilder.cs:324
		    yield return Code_PectoralisMuscleInvolvement;                                                                                        // CSBuilder.cs:324
		    yield return Code_PectoralisMuscleTenting;                                                                                            // CSBuilder.cs:324
		    yield return Code_PostSurgicalScar;                                                                                                   // CSBuilder.cs:324
		    yield return Code_Seroma;                                                                                                             // CSBuilder.cs:324
		    yield return Code_SkinInvolvement;                                                                                                    // CSBuilder.cs:324
		    yield return Code_SkinLesion;                                                                                                         // CSBuilder.cs:324
		    yield return Code_SkinRetraction;                                                                                                     // CSBuilder.cs:324
		    yield return Code_SkinThickening;                                                                                                     // CSBuilder.cs:324
		    yield return Code_SurgicalClip;                                                                                                       // CSBuilder.cs:324
		    yield return Code_SurgicalClips;                                                                                                      // CSBuilder.cs:324
		    yield return Code_TrabecularThickening;                                                                                               // CSBuilder.cs:324
		}                                                                                                                                         // CSBuilder.cs:330
		//- Methods
	}
}
