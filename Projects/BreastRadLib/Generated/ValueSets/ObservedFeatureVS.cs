using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	//+ Header
	public class ObservedFeatureVS                                                                                                             // CSBuilder.cs:333
	//- Header
	{
		//+ Fields
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding                                                                                                                      // CSBuilder.cs:354
		{                                                                                                                                         // CSBuilder.cs:355
		    Coding value;                                                                                                                         // CSBuilder.cs:356
		    public static implicit operator Coding(TCoding tCode)                                                                                 // CSBuilder.cs:357
		    {                                                                                                                                     // CSBuilder.cs:358
		        return tCode.value;                                                                                                               // CSBuilder.cs:359
		    }                                                                                                                                     // CSBuilder.cs:360
		                                                                                                                                          // CSBuilder.cs:361
		    public TCoding(Coding value)                                                                                                          // CSBuilder.cs:362
		    {                                                                                                                                     // CSBuilder.cs:363
		        this.value= value;                                                                                                                // CSBuilder.cs:364
		    }                                                                                                                                     // CSBuilder.cs:365
		}                                                                                                                                         // CSBuilder.cs:366
		public TCoding Code_ArchitecturalDistortion = new TCoding(ObservedFeatureCS.Code_ArchitecturalDistortion);                                // CSBuilder.cs:384
		public TCoding Code_AxillaryAdenopathy = new TCoding(ObservedFeatureCS.Code_AxillaryAdenopathy);                                          // CSBuilder.cs:384
		public TCoding Code_BiopsyClip = new TCoding(ObservedFeatureCS.Code_BiopsyClip);                                                          // CSBuilder.cs:384
		public TCoding Code_BiopsyClips = new TCoding(ObservedFeatureCS.Code_BiopsyClips);                                                        // CSBuilder.cs:384
		public TCoding Code_BrachytherapyTube = new TCoding(ObservedFeatureCS.Code_BrachytherapyTube);                                            // CSBuilder.cs:384
		public TCoding Code_ChestWallInvasion = new TCoding(ObservedFeatureCS.Code_ChestWallInvasion);                                            // CSBuilder.cs:384
		public TCoding Code_CooperDistorted = new TCoding(ObservedFeatureCS.Code_CooperDistorted);                                                // CSBuilder.cs:384
		public TCoding Code_CooperThickened = new TCoding(ObservedFeatureCS.Code_CooperThickened);                                                // CSBuilder.cs:384
		public TCoding Code_Edema = new TCoding(ObservedFeatureCS.Code_Edema);                                                                    // CSBuilder.cs:384
		public TCoding Code_EdemaAdj = new TCoding(ObservedFeatureCS.Code_EdemaAdj);                                                              // CSBuilder.cs:384
		public TCoding Code_GoldSeed = new TCoding(ObservedFeatureCS.Code_GoldSeed);                                                              // CSBuilder.cs:384
		public TCoding Code_Hematoma = new TCoding(ObservedFeatureCS.Code_Hematoma);                                                              // CSBuilder.cs:384
		public TCoding Code_NippleRetraction = new TCoding(ObservedFeatureCS.Code_NippleRetraction);                                              // CSBuilder.cs:384
		public TCoding Code_NOChestWallInvasion = new TCoding(ObservedFeatureCS.Code_NOChestWallInvasion);                                        // CSBuilder.cs:384
		public TCoding Code_PectoralisMuscleInvasion = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvasion);                              // CSBuilder.cs:384
		public TCoding Code_PectoralisMuscleInvolvement = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleInvolvement);                        // CSBuilder.cs:384
		public TCoding Code_PectoralisMuscleTenting = new TCoding(ObservedFeatureCS.Code_PectoralisMuscleTenting);                                // CSBuilder.cs:384
		public TCoding Code_PostSurgicalScar = new TCoding(ObservedFeatureCS.Code_PostSurgicalScar);                                              // CSBuilder.cs:384
		public TCoding Code_Seroma = new TCoding(ObservedFeatureCS.Code_Seroma);                                                                  // CSBuilder.cs:384
		public TCoding Code_SkinInvolvement = new TCoding(ObservedFeatureCS.Code_SkinInvolvement);                                                // CSBuilder.cs:384
		public TCoding Code_SkinLesion = new TCoding(ObservedFeatureCS.Code_SkinLesion);                                                          // CSBuilder.cs:384
		public TCoding Code_SkinRetraction = new TCoding(ObservedFeatureCS.Code_SkinRetraction);                                                  // CSBuilder.cs:384
		public TCoding Code_SkinThickening = new TCoding(ObservedFeatureCS.Code_SkinThickening);                                                  // CSBuilder.cs:384
		public TCoding Code_SurgicalClip = new TCoding(ObservedFeatureCS.Code_SurgicalClip);                                                      // CSBuilder.cs:384
		public TCoding Code_SurgicalClips = new TCoding(ObservedFeatureCS.Code_SurgicalClips);                                                    // CSBuilder.cs:384
		public TCoding Code_TrabecularThickening = new TCoding(ObservedFeatureCS.Code_TrabecularThickening);                                      // CSBuilder.cs:384
		                                                                                                                                          // CSBuilder.cs:339
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:340
		                                                                                                                                          // CSBuilder.cs:341
		public ObservedFeatureVS()                                                                                                                // CSBuilder.cs:342
		{                                                                                                                                         // CSBuilder.cs:343
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:344
		    this.Members.Add(this.Code_ArchitecturalDistortion);                                                                                  // CSBuilder.cs:387
		    this.Members.Add(this.Code_AxillaryAdenopathy);                                                                                       // CSBuilder.cs:387
		    this.Members.Add(this.Code_BiopsyClip);                                                                                               // CSBuilder.cs:387
		    this.Members.Add(this.Code_BiopsyClips);                                                                                              // CSBuilder.cs:387
		    this.Members.Add(this.Code_BrachytherapyTube);                                                                                        // CSBuilder.cs:387
		    this.Members.Add(this.Code_ChestWallInvasion);                                                                                        // CSBuilder.cs:387
		    this.Members.Add(this.Code_CooperDistorted);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_CooperThickened);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_Edema);                                                                                                    // CSBuilder.cs:387
		    this.Members.Add(this.Code_EdemaAdj);                                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_GoldSeed);                                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_Hematoma);                                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_NippleRetraction);                                                                                         // CSBuilder.cs:387
		    this.Members.Add(this.Code_NOChestWallInvasion);                                                                                      // CSBuilder.cs:387
		    this.Members.Add(this.Code_PectoralisMuscleInvasion);                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_PectoralisMuscleInvolvement);                                                                              // CSBuilder.cs:387
		    this.Members.Add(this.Code_PectoralisMuscleTenting);                                                                                  // CSBuilder.cs:387
		    this.Members.Add(this.Code_PostSurgicalScar);                                                                                         // CSBuilder.cs:387
		    this.Members.Add(this.Code_Seroma);                                                                                                   // CSBuilder.cs:387
		    this.Members.Add(this.Code_SkinInvolvement);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_SkinLesion);                                                                                               // CSBuilder.cs:387
		    this.Members.Add(this.Code_SkinRetraction);                                                                                           // CSBuilder.cs:387
		    this.Members.Add(this.Code_SkinThickening);                                                                                           // CSBuilder.cs:387
		    this.Members.Add(this.Code_SurgicalClip);                                                                                             // CSBuilder.cs:387
		    this.Members.Add(this.Code_SurgicalClips);                                                                                            // CSBuilder.cs:387
		    this.Members.Add(this.Code_TrabecularThickening);                                                                                     // CSBuilder.cs:387
		}                                                                                                                                         // CSBuilder.cs:346
		//- Fields
	}
}
