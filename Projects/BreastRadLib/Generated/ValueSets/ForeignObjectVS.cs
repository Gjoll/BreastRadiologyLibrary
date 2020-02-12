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
	public class ForeignObjectVS                                                                                                               // CSBuilder.cs:333
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
		public TCoding Code_BBPellet = new TCoding(ForeignObjectCS.Code_BBPellet);                                                                // CSBuilder.cs:384
		public TCoding Code_BBPellets = new TCoding(ForeignObjectCS.Code_BBPellets);                                                              // CSBuilder.cs:384
		public TCoding Code_BiopsyClip = new TCoding(ForeignObjectCS.Code_BiopsyClip);                                                            // CSBuilder.cs:384
		public TCoding Code_BiopsyClips = new TCoding(ForeignObjectCS.Code_BiopsyClips);                                                          // CSBuilder.cs:384
		public TCoding Code_BreastMarker = new TCoding(ForeignObjectCS.Code_BreastMarker);                                                        // CSBuilder.cs:384
		public TCoding Code_BreastMarkers = new TCoding(ForeignObjectCS.Code_BreastMarkers);                                                      // CSBuilder.cs:384
		public TCoding Code_CatheterSleeves = new TCoding(ForeignObjectCS.Code_CatheterSleeves);                                                  // CSBuilder.cs:384
		public TCoding Code_ChemotherapyPort = new TCoding(ForeignObjectCS.Code_ChemotherapyPort);                                                // CSBuilder.cs:384
		public TCoding Code_Clip = new TCoding(ForeignObjectCS.Code_Clip);                                                                        // CSBuilder.cs:384
		public TCoding Code_Clips = new TCoding(ForeignObjectCS.Code_Clips);                                                                      // CSBuilder.cs:384
		public TCoding Code_Coil = new TCoding(ForeignObjectCS.Code_Coil);                                                                        // CSBuilder.cs:384
		public TCoding Code_Glass = new TCoding(ForeignObjectCS.Code_Glass);                                                                      // CSBuilder.cs:384
		public TCoding Code_GoldSeed = new TCoding(ForeignObjectCS.Code_GoldSeed);                                                                // CSBuilder.cs:384
		public TCoding Code_GunshotWound = new TCoding(ForeignObjectCS.Code_GunshotWound);                                                        // CSBuilder.cs:384
		public TCoding Code_MarkerClip = new TCoding(ForeignObjectCS.Code_MarkerClip);                                                            // CSBuilder.cs:384
		public TCoding Code_Metal = new TCoding(ForeignObjectCS.Code_Metal);                                                                      // CSBuilder.cs:384
		public TCoding Code_MetallicMarker = new TCoding(ForeignObjectCS.Code_MetallicMarker);                                                    // CSBuilder.cs:384
		public TCoding Code_MetallicMarkers = new TCoding(ForeignObjectCS.Code_MetallicMarkers);                                                  // CSBuilder.cs:384
		public TCoding Code_MetallicObjects = new TCoding(ForeignObjectCS.Code_MetallicObjects);                                                  // CSBuilder.cs:384
		public TCoding Code_Needle = new TCoding(ForeignObjectCS.Code_Needle);                                                                    // CSBuilder.cs:384
		public TCoding Code_NippleJewelry = new TCoding(ForeignObjectCS.Code_NippleJewelry);                                                      // CSBuilder.cs:384
		public TCoding Code_NonMetallicBody = new TCoding(ForeignObjectCS.Code_NonMetallicBody);                                                  // CSBuilder.cs:384
		public TCoding Code_Pacemaker = new TCoding(ForeignObjectCS.Code_Pacemaker);                                                              // CSBuilder.cs:384
		public TCoding Code_SiliconeGranuloma = new TCoding(ForeignObjectCS.Code_SiliconeGranuloma);                                              // CSBuilder.cs:384
		public TCoding Code_Sponge = new TCoding(ForeignObjectCS.Code_Sponge);                                                                    // CSBuilder.cs:384
		public TCoding Code_SurgicalClip = new TCoding(ForeignObjectCS.Code_SurgicalClip);                                                        // CSBuilder.cs:384
		public TCoding Code_SurgicalClips = new TCoding(ForeignObjectCS.Code_SurgicalClips);                                                      // CSBuilder.cs:384
		public TCoding Code_Swab = new TCoding(ForeignObjectCS.Code_Swab);                                                                        // CSBuilder.cs:384
		public TCoding Code_TitaniumClip = new TCoding(ForeignObjectCS.Code_TitaniumClip);                                                        // CSBuilder.cs:384
		public TCoding Code_TitaniumClips = new TCoding(ForeignObjectCS.Code_TitaniumClips);                                                      // CSBuilder.cs:384
		public TCoding Code_Wire = new TCoding(ForeignObjectCS.Code_Wire);                                                                        // CSBuilder.cs:384
		public TCoding Code_WireFragment = new TCoding(ForeignObjectCS.Code_WireFragment);                                                        // CSBuilder.cs:384
		                                                                                                                                          // CSBuilder.cs:339
		public List<Coding> Members;                                                                                                              // CSBuilder.cs:340
		                                                                                                                                          // CSBuilder.cs:341
		public ForeignObjectVS()                                                                                                                  // CSBuilder.cs:342
		{                                                                                                                                         // CSBuilder.cs:343
		    this.Members = new List<Coding>();                                                                                                    // CSBuilder.cs:344
		    this.Members.Add(this.Code_BBPellet);                                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_BBPellets);                                                                                                // CSBuilder.cs:387
		    this.Members.Add(this.Code_BiopsyClip);                                                                                               // CSBuilder.cs:387
		    this.Members.Add(this.Code_BiopsyClips);                                                                                              // CSBuilder.cs:387
		    this.Members.Add(this.Code_BreastMarker);                                                                                             // CSBuilder.cs:387
		    this.Members.Add(this.Code_BreastMarkers);                                                                                            // CSBuilder.cs:387
		    this.Members.Add(this.Code_CatheterSleeves);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_ChemotherapyPort);                                                                                         // CSBuilder.cs:387
		    this.Members.Add(this.Code_Clip);                                                                                                     // CSBuilder.cs:387
		    this.Members.Add(this.Code_Clips);                                                                                                    // CSBuilder.cs:387
		    this.Members.Add(this.Code_Coil);                                                                                                     // CSBuilder.cs:387
		    this.Members.Add(this.Code_Glass);                                                                                                    // CSBuilder.cs:387
		    this.Members.Add(this.Code_GoldSeed);                                                                                                 // CSBuilder.cs:387
		    this.Members.Add(this.Code_GunshotWound);                                                                                             // CSBuilder.cs:387
		    this.Members.Add(this.Code_MarkerClip);                                                                                               // CSBuilder.cs:387
		    this.Members.Add(this.Code_Metal);                                                                                                    // CSBuilder.cs:387
		    this.Members.Add(this.Code_MetallicMarker);                                                                                           // CSBuilder.cs:387
		    this.Members.Add(this.Code_MetallicMarkers);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_MetallicObjects);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_Needle);                                                                                                   // CSBuilder.cs:387
		    this.Members.Add(this.Code_NippleJewelry);                                                                                            // CSBuilder.cs:387
		    this.Members.Add(this.Code_NonMetallicBody);                                                                                          // CSBuilder.cs:387
		    this.Members.Add(this.Code_Pacemaker);                                                                                                // CSBuilder.cs:387
		    this.Members.Add(this.Code_SiliconeGranuloma);                                                                                        // CSBuilder.cs:387
		    this.Members.Add(this.Code_Sponge);                                                                                                   // CSBuilder.cs:387
		    this.Members.Add(this.Code_SurgicalClip);                                                                                             // CSBuilder.cs:387
		    this.Members.Add(this.Code_SurgicalClips);                                                                                            // CSBuilder.cs:387
		    this.Members.Add(this.Code_Swab);                                                                                                     // CSBuilder.cs:387
		    this.Members.Add(this.Code_TitaniumClip);                                                                                             // CSBuilder.cs:387
		    this.Members.Add(this.Code_TitaniumClips);                                                                                            // CSBuilder.cs:387
		    this.Members.Add(this.Code_Wire);                                                                                                     // CSBuilder.cs:387
		    this.Members.Add(this.Code_WireFragment);                                                                                             // CSBuilder.cs:387
		}                                                                                                                                         // CSBuilder.cs:346
		//- Fields
	}
}
