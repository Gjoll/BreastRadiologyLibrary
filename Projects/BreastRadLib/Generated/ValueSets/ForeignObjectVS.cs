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
		public static TCoding Code_BBPellet = new TCoding(ForeignObjectCS.Code_BBPellet);                                                         // Builder.cs:353
		public static TCoding Code_BBPellets = new TCoding(ForeignObjectCS.Code_BBPellets);                                                       // Builder.cs:353
		public static TCoding Code_BiopsyClip = new TCoding(ForeignObjectCS.Code_BiopsyClip);                                                     // Builder.cs:353
		public static TCoding Code_BiopsyClips = new TCoding(ForeignObjectCS.Code_BiopsyClips);                                                   // Builder.cs:353
		public static TCoding Code_BreastMarker = new TCoding(ForeignObjectCS.Code_BreastMarker);                                                 // Builder.cs:353
		public static TCoding Code_CatheterSleeves = new TCoding(ForeignObjectCS.Code_CatheterSleeves);                                           // Builder.cs:353
		public static TCoding Code_ChemotherapyPort = new TCoding(ForeignObjectCS.Code_ChemotherapyPort);                                         // Builder.cs:353
		public static TCoding Code_Coil = new TCoding(ForeignObjectCS.Code_Coil);                                                                 // Builder.cs:353
		public static TCoding Code_Glass = new TCoding(ForeignObjectCS.Code_Glass);                                                               // Builder.cs:353
		public static TCoding Code_GoldSeed = new TCoding(ForeignObjectCS.Code_GoldSeed);                                                         // Builder.cs:353
		public static TCoding Code_GunshotWound = new TCoding(ForeignObjectCS.Code_GunshotWound);                                                 // Builder.cs:353
		public static TCoding Code_MarkerClip = new TCoding(ForeignObjectCS.Code_MarkerClip);                                                     // Builder.cs:353
		public static TCoding Code_Metal = new TCoding(ForeignObjectCS.Code_Metal);                                                               // Builder.cs:353
		public static TCoding Code_MetallicMarker = new TCoding(ForeignObjectCS.Code_MetallicMarker);                                             // Builder.cs:353
		public static TCoding Code_MetallicMarkers = new TCoding(ForeignObjectCS.Code_MetallicMarkers);                                           // Builder.cs:353
		public static TCoding Code_MetallicObjects = new TCoding(ForeignObjectCS.Code_MetallicObjects);                                           // Builder.cs:353
		public static TCoding Code_Needle = new TCoding(ForeignObjectCS.Code_Needle);                                                             // Builder.cs:353
		public static TCoding Code_NippleJewelry = new TCoding(ForeignObjectCS.Code_NippleJewelry);                                               // Builder.cs:353
		public static TCoding Code_NonMetallicBody = new TCoding(ForeignObjectCS.Code_NonMetallicBody);                                           // Builder.cs:353
		public static TCoding Code_Pacemaker = new TCoding(ForeignObjectCS.Code_Pacemaker);                                                       // Builder.cs:353
		public static TCoding Code_SiliconeGranuloma = new TCoding(ForeignObjectCS.Code_SiliconeGranuloma);                                       // Builder.cs:353
		public static TCoding Code_Sponge = new TCoding(ForeignObjectCS.Code_Sponge);                                                             // Builder.cs:353
		public static TCoding Code_SurgicalClip = new TCoding(ForeignObjectCS.Code_SurgicalClip);                                                 // Builder.cs:353
		public static TCoding Code_SurgicalClips = new TCoding(ForeignObjectCS.Code_SurgicalClips);                                               // Builder.cs:353
		public static TCoding Code_Swab = new TCoding(ForeignObjectCS.Code_Swab);                                                                 // Builder.cs:353
		public static TCoding Code_TitaniumClip = new TCoding(ForeignObjectCS.Code_TitaniumClip);                                                 // Builder.cs:353
		public static TCoding Code_TitaniumClips = new TCoding(ForeignObjectCS.Code_TitaniumClips);                                               // Builder.cs:353
		public static TCoding Code_Wire = new TCoding(ForeignObjectCS.Code_Wire);                                                                 // Builder.cs:353
		public static TCoding Code_WireFragment = new TCoding(ForeignObjectCS.Code_WireFragment);                                                 // Builder.cs:353
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:339
		{                                                                                                                                         // Builder.cs:340
		    yield return Code_BBPellet;                                                                                                           // Builder.cs:356
		    yield return Code_BBPellets;                                                                                                          // Builder.cs:356
		    yield return Code_BiopsyClip;                                                                                                         // Builder.cs:356
		    yield return Code_BiopsyClips;                                                                                                        // Builder.cs:356
		    yield return Code_BreastMarker;                                                                                                       // Builder.cs:356
		    yield return Code_CatheterSleeves;                                                                                                    // Builder.cs:356
		    yield return Code_ChemotherapyPort;                                                                                                   // Builder.cs:356
		    yield return Code_Coil;                                                                                                               // Builder.cs:356
		    yield return Code_Glass;                                                                                                              // Builder.cs:356
		    yield return Code_GoldSeed;                                                                                                           // Builder.cs:356
		    yield return Code_GunshotWound;                                                                                                       // Builder.cs:356
		    yield return Code_MarkerClip;                                                                                                         // Builder.cs:356
		    yield return Code_Metal;                                                                                                              // Builder.cs:356
		    yield return Code_MetallicMarker;                                                                                                     // Builder.cs:356
		    yield return Code_MetallicMarkers;                                                                                                    // Builder.cs:356
		    yield return Code_MetallicObjects;                                                                                                    // Builder.cs:356
		    yield return Code_Needle;                                                                                                             // Builder.cs:356
		    yield return Code_NippleJewelry;                                                                                                      // Builder.cs:356
		    yield return Code_NonMetallicBody;                                                                                                    // Builder.cs:356
		    yield return Code_Pacemaker;                                                                                                          // Builder.cs:356
		    yield return Code_SiliconeGranuloma;                                                                                                  // Builder.cs:356
		    yield return Code_Sponge;                                                                                                             // Builder.cs:356
		    yield return Code_SurgicalClip;                                                                                                       // Builder.cs:356
		    yield return Code_SurgicalClips;                                                                                                      // Builder.cs:356
		    yield return Code_Swab;                                                                                                               // Builder.cs:356
		    yield return Code_TitaniumClip;                                                                                                       // Builder.cs:356
		    yield return Code_TitaniumClips;                                                                                                      // Builder.cs:356
		    yield return Code_Wire;                                                                                                               // Builder.cs:356
		    yield return Code_WireFragment;                                                                                                       // Builder.cs:356
		}                                                                                                                                         // Builder.cs:362
		//- Methods
	}
}
