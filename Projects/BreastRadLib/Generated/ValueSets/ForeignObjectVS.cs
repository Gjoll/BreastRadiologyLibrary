using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ForeignObjectVS
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
		public static TCoding Code_BBPellet = new TCoding(ForeignObjectCS.Code_BBPellet);                                                         // CSBuilder.cs:320
		public static TCoding Code_BBPellets = new TCoding(ForeignObjectCS.Code_BBPellets);                                                       // CSBuilder.cs:320
		public static TCoding Code_BiopsyClip = new TCoding(ForeignObjectCS.Code_BiopsyClip);                                                     // CSBuilder.cs:320
		public static TCoding Code_BiopsyClips = new TCoding(ForeignObjectCS.Code_BiopsyClips);                                                   // CSBuilder.cs:320
		public static TCoding Code_BreastMarker = new TCoding(ForeignObjectCS.Code_BreastMarker);                                                 // CSBuilder.cs:320
		public static TCoding Code_BreastMarkers = new TCoding(ForeignObjectCS.Code_BreastMarkers);                                               // CSBuilder.cs:320
		public static TCoding Code_CatheterSleeves = new TCoding(ForeignObjectCS.Code_CatheterSleeves);                                           // CSBuilder.cs:320
		public static TCoding Code_ChemotherapyPort = new TCoding(ForeignObjectCS.Code_ChemotherapyPort);                                         // CSBuilder.cs:320
		public static TCoding Code_Clip = new TCoding(ForeignObjectCS.Code_Clip);                                                                 // CSBuilder.cs:320
		public static TCoding Code_Clips = new TCoding(ForeignObjectCS.Code_Clips);                                                               // CSBuilder.cs:320
		public static TCoding Code_Coil = new TCoding(ForeignObjectCS.Code_Coil);                                                                 // CSBuilder.cs:320
		public static TCoding Code_Glass = new TCoding(ForeignObjectCS.Code_Glass);                                                               // CSBuilder.cs:320
		public static TCoding Code_GoldSeed = new TCoding(ForeignObjectCS.Code_GoldSeed);                                                         // CSBuilder.cs:320
		public static TCoding Code_GunshotWound = new TCoding(ForeignObjectCS.Code_GunshotWound);                                                 // CSBuilder.cs:320
		public static TCoding Code_MarkerClip = new TCoding(ForeignObjectCS.Code_MarkerClip);                                                     // CSBuilder.cs:320
		public static TCoding Code_Metal = new TCoding(ForeignObjectCS.Code_Metal);                                                               // CSBuilder.cs:320
		public static TCoding Code_MetallicMarker = new TCoding(ForeignObjectCS.Code_MetallicMarker);                                             // CSBuilder.cs:320
		public static TCoding Code_MetallicMarkers = new TCoding(ForeignObjectCS.Code_MetallicMarkers);                                           // CSBuilder.cs:320
		public static TCoding Code_MetallicObjects = new TCoding(ForeignObjectCS.Code_MetallicObjects);                                           // CSBuilder.cs:320
		public static TCoding Code_Needle = new TCoding(ForeignObjectCS.Code_Needle);                                                             // CSBuilder.cs:320
		public static TCoding Code_NippleJewelry = new TCoding(ForeignObjectCS.Code_NippleJewelry);                                               // CSBuilder.cs:320
		public static TCoding Code_NonMetallicBody = new TCoding(ForeignObjectCS.Code_NonMetallicBody);                                           // CSBuilder.cs:320
		public static TCoding Code_Pacemaker = new TCoding(ForeignObjectCS.Code_Pacemaker);                                                       // CSBuilder.cs:320
		public static TCoding Code_SiliconeGranuloma = new TCoding(ForeignObjectCS.Code_SiliconeGranuloma);                                       // CSBuilder.cs:320
		public static TCoding Code_Sponge = new TCoding(ForeignObjectCS.Code_Sponge);                                                             // CSBuilder.cs:320
		public static TCoding Code_SurgicalClip = new TCoding(ForeignObjectCS.Code_SurgicalClip);                                                 // CSBuilder.cs:320
		public static TCoding Code_SurgicalClips = new TCoding(ForeignObjectCS.Code_SurgicalClips);                                               // CSBuilder.cs:320
		public static TCoding Code_Swab = new TCoding(ForeignObjectCS.Code_Swab);                                                                 // CSBuilder.cs:320
		public static TCoding Code_TitaniumClip = new TCoding(ForeignObjectCS.Code_TitaniumClip);                                                 // CSBuilder.cs:320
		public static TCoding Code_TitaniumClips = new TCoding(ForeignObjectCS.Code_TitaniumClips);                                               // CSBuilder.cs:320
		public static TCoding Code_Wire = new TCoding(ForeignObjectCS.Code_Wire);                                                                 // CSBuilder.cs:320
		public static TCoding Code_WireFragment = new TCoding(ForeignObjectCS.Code_WireFragment);                                                 // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_BBPellet;                                                                                                           // CSBuilder.cs:323
		    yield return Code_BBPellets;                                                                                                          // CSBuilder.cs:323
		    yield return Code_BiopsyClip;                                                                                                         // CSBuilder.cs:323
		    yield return Code_BiopsyClips;                                                                                                        // CSBuilder.cs:323
		    yield return Code_BreastMarker;                                                                                                       // CSBuilder.cs:323
		    yield return Code_BreastMarkers;                                                                                                      // CSBuilder.cs:323
		    yield return Code_CatheterSleeves;                                                                                                    // CSBuilder.cs:323
		    yield return Code_ChemotherapyPort;                                                                                                   // CSBuilder.cs:323
		    yield return Code_Clip;                                                                                                               // CSBuilder.cs:323
		    yield return Code_Clips;                                                                                                              // CSBuilder.cs:323
		    yield return Code_Coil;                                                                                                               // CSBuilder.cs:323
		    yield return Code_Glass;                                                                                                              // CSBuilder.cs:323
		    yield return Code_GoldSeed;                                                                                                           // CSBuilder.cs:323
		    yield return Code_GunshotWound;                                                                                                       // CSBuilder.cs:323
		    yield return Code_MarkerClip;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Metal;                                                                                                              // CSBuilder.cs:323
		    yield return Code_MetallicMarker;                                                                                                     // CSBuilder.cs:323
		    yield return Code_MetallicMarkers;                                                                                                    // CSBuilder.cs:323
		    yield return Code_MetallicObjects;                                                                                                    // CSBuilder.cs:323
		    yield return Code_Needle;                                                                                                             // CSBuilder.cs:323
		    yield return Code_NippleJewelry;                                                                                                      // CSBuilder.cs:323
		    yield return Code_NonMetallicBody;                                                                                                    // CSBuilder.cs:323
		    yield return Code_Pacemaker;                                                                                                          // CSBuilder.cs:323
		    yield return Code_SiliconeGranuloma;                                                                                                  // CSBuilder.cs:323
		    yield return Code_Sponge;                                                                                                             // CSBuilder.cs:323
		    yield return Code_SurgicalClip;                                                                                                       // CSBuilder.cs:323
		    yield return Code_SurgicalClips;                                                                                                      // CSBuilder.cs:323
		    yield return Code_Swab;                                                                                                               // CSBuilder.cs:323
		    yield return Code_TitaniumClip;                                                                                                       // CSBuilder.cs:323
		    yield return Code_TitaniumClips;                                                                                                      // CSBuilder.cs:323
		    yield return Code_Wire;                                                                                                               // CSBuilder.cs:323
		    yield return Code_WireFragment;                                                                                                       // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
