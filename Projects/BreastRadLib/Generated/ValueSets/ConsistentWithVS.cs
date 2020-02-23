using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ConsistentWithVS
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
		public static TCoding Code_Abscess = new TCoding(ConsistentWithCodeSystemCS.Code_Abscess);                                                // Builder.cs:349
		public static TCoding Code_Angiolipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Angiolipoma);                                        // Builder.cs:349
		public static TCoding Code_ApocrineMetaplasia = new TCoding(ConsistentWithCodeSystemCS.Code_ApocrineMetaplasia);                          // Builder.cs:349
		public static TCoding Code_Artifact = new TCoding(ConsistentWithCodeSystemCS.Code_Artifact);                                              // Builder.cs:349
		public static TCoding Code_AtypicalHyperplasia = new TCoding(ConsistentWithCodeSystemCS.Code_AtypicalHyperplasia);                        // Builder.cs:349
		public static TCoding Code_AxillaryLymphNode = new TCoding(ConsistentWithCodeSystemCS.Code_AxillaryLymphNode);                            // Builder.cs:349
		public static TCoding Code_Carcinoma = new TCoding(ConsistentWithCodeSystemCS.Code_Carcinoma);                                            // Builder.cs:349
		public static TCoding Code_CarcinomaKnown = new TCoding(ConsistentWithCodeSystemCS.Code_CarcinomaKnown);                                  // Builder.cs:349
		public static TCoding Code_ClusterOfCysts = new TCoding(ConsistentWithCodeSystemCS.Code_ClusterOfCysts);                                  // Builder.cs:349
		public static TCoding Code_Cyst = new TCoding(ConsistentWithCodeSystemCS.Code_Cyst);                                                      // Builder.cs:349
		public static TCoding Code_CystComplex = new TCoding(ConsistentWithCodeSystemCS.Code_CystComplex);                                        // Builder.cs:349
		public static TCoding Code_CystComplicated = new TCoding(ConsistentWithCodeSystemCS.Code_CystComplicated);                                // Builder.cs:349
		public static TCoding Code_CystOil = new TCoding(ConsistentWithCodeSystemCS.Code_CystOil);                                                // Builder.cs:349
		public static TCoding Code_CystSebaceous = new TCoding(ConsistentWithCodeSystemCS.Code_CystSebaceous);                                    // Builder.cs:349
		public static TCoding Code_CystSimple = new TCoding(ConsistentWithCodeSystemCS.Code_CystSimple);                                          // Builder.cs:349
		public static TCoding Code_CystsComplex = new TCoding(ConsistentWithCodeSystemCS.Code_CystsComplex);                                      // Builder.cs:349
		public static TCoding Code_CystsComplicated = new TCoding(ConsistentWithCodeSystemCS.Code_CystsComplicated);                              // Builder.cs:349
		public static TCoding Code_CystsMicroClustered = new TCoding(ConsistentWithCodeSystemCS.Code_CystsMicroClustered);                        // Builder.cs:349
		public static TCoding Code_DCIS = new TCoding(ConsistentWithCodeSystemCS.Code_DCIS);                                                      // Builder.cs:349
		public static TCoding Code_Debris = new TCoding(ConsistentWithCodeSystemCS.Code_Debris);                                                  // Builder.cs:349
		public static TCoding Code_Deodorant = new TCoding(ConsistentWithCodeSystemCS.Code_Deodorant);                                            // Builder.cs:349
		public static TCoding Code_DermalCalcification = new TCoding(ConsistentWithCodeSystemCS.Code_DermalCalcification);                        // Builder.cs:349
		public static TCoding Code_DuctEctasia = new TCoding(ConsistentWithCodeSystemCS.Code_DuctEctasia);                                        // Builder.cs:349
		public static TCoding Code_Edema = new TCoding(ConsistentWithCodeSystemCS.Code_Edema);                                                    // Builder.cs:349
		public static TCoding Code_FatLobule = new TCoding(ConsistentWithCodeSystemCS.Code_FatLobule);                                            // Builder.cs:349
		public static TCoding Code_FatNecrosis = new TCoding(ConsistentWithCodeSystemCS.Code_FatNecrosis);                                        // Builder.cs:349
		public static TCoding Code_Fibroadenolipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Fibroadenolipoma);                              // Builder.cs:349
		public static TCoding Code_Fibroadenoma = new TCoding(ConsistentWithCodeSystemCS.Code_Fibroadenoma);                                      // Builder.cs:349
		public static TCoding Code_FibroadenomaDegenerating = new TCoding(ConsistentWithCodeSystemCS.Code_FibroadenomaDegenerating);              // Builder.cs:349
		public static TCoding Code_FibrocysticChange = new TCoding(ConsistentWithCodeSystemCS.Code_FibrocysticChange);                            // Builder.cs:349
		public static TCoding Code_FibroglandularTissue = new TCoding(ConsistentWithCodeSystemCS.Code_FibroglandularTissue);                      // Builder.cs:349
		public static TCoding Code_Fibrosis = new TCoding(ConsistentWithCodeSystemCS.Code_Fibrosis);                                              // Builder.cs:349
		public static TCoding Code_FibrousRidge = new TCoding(ConsistentWithCodeSystemCS.Code_FibrousRidge);                                      // Builder.cs:349
		public static TCoding Code_Folliculitis = new TCoding(ConsistentWithCodeSystemCS.Code_Folliculitis);                                      // Builder.cs:349
		public static TCoding Code_Gynecomastia = new TCoding(ConsistentWithCodeSystemCS.Code_Gynecomastia);                                      // Builder.cs:349
		public static TCoding Code_Hamartoma = new TCoding(ConsistentWithCodeSystemCS.Code_Hamartoma);                                            // Builder.cs:349
		public static TCoding Code_Hematoma = new TCoding(ConsistentWithCodeSystemCS.Code_Hematoma);                                              // Builder.cs:349
		public static TCoding Code_HormonalStimulation = new TCoding(ConsistentWithCodeSystemCS.Code_HormonalStimulation);                        // Builder.cs:349
		public static TCoding Code_IntracysticLesion = new TCoding(ConsistentWithCodeSystemCS.Code_IntracysticLesion);                            // Builder.cs:349
		public static TCoding Code_IntramammaryNode = new TCoding(ConsistentWithCodeSystemCS.Code_IntramammaryNode);                              // Builder.cs:349
		public static TCoding Code_Lipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Lipoma);                                                  // Builder.cs:349
		public static TCoding Code_LumpectomyCavity = new TCoding(ConsistentWithCodeSystemCS.Code_LumpectomyCavity);                              // Builder.cs:349
		public static TCoding Code_LumpectomySite = new TCoding(ConsistentWithCodeSystemCS.Code_LumpectomySite);                                  // Builder.cs:349
		public static TCoding Code_LymphNode = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNode);                                            // Builder.cs:349
		public static TCoding Code_LymphNodeEnlarged = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodeEnlarged);                            // Builder.cs:349
		public static TCoding Code_LymphNodeNormal = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodeNormal);                                // Builder.cs:349
		public static TCoding Code_LymphNodePathological = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodePathological);                    // Builder.cs:349
		public static TCoding Code_MassSolid = new TCoding(ConsistentWithCodeSystemCS.Code_MassSolid);                                            // Builder.cs:349
		public static TCoding Code_MassSolidWTumorVasc = new TCoding(ConsistentWithCodeSystemCS.Code_MassSolidWTumorVasc);                        // Builder.cs:349
		public static TCoding Code_Mastitis = new TCoding(ConsistentWithCodeSystemCS.Code_Mastitis);                                              // Builder.cs:349
		public static TCoding Code_MilkOfCalcium = new TCoding(ConsistentWithCodeSystemCS.Code_MilkOfCalcium);                                    // Builder.cs:349
		public static TCoding Code_MultiFocalCancer = new TCoding(ConsistentWithCodeSystemCS.Code_MultiFocalCancer);                              // Builder.cs:349
		public static TCoding Code_PapillaryLesion = new TCoding(ConsistentWithCodeSystemCS.Code_PapillaryLesion);                                // Builder.cs:349
		public static TCoding Code_Papilloma = new TCoding(ConsistentWithCodeSystemCS.Code_Papilloma);                                            // Builder.cs:349
		public static TCoding Code_PhyllodesTumor = new TCoding(ConsistentWithCodeSystemCS.Code_PhyllodesTumor);                                  // Builder.cs:349
		public static TCoding Code_PostLumpectomyScar = new TCoding(ConsistentWithCodeSystemCS.Code_PostLumpectomyScar);                          // Builder.cs:349
		public static TCoding Code_PostSurgicalScar = new TCoding(ConsistentWithCodeSystemCS.Code_PostSurgicalScar);                              // Builder.cs:349
		public static TCoding Code_PreviousBiopsy = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousBiopsy);                                  // Builder.cs:349
		public static TCoding Code_PreviousSurgery = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousSurgery);                                // Builder.cs:349
		public static TCoding Code_PreviousTrauma = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousTrauma);                                  // Builder.cs:349
		public static TCoding Code_RadialScar = new TCoding(ConsistentWithCodeSystemCS.Code_RadialScar);                                          // Builder.cs:349
		public static TCoding Code_RadiationChanges = new TCoding(ConsistentWithCodeSystemCS.Code_RadiationChanges);                              // Builder.cs:349
		public static TCoding Code_RadiationTherapy = new TCoding(ConsistentWithCodeSystemCS.Code_RadiationTherapy);                              // Builder.cs:349
		public static TCoding Code_Scar = new TCoding(ConsistentWithCodeSystemCS.Code_Scar);                                                      // Builder.cs:349
		public static TCoding Code_ScarWithShadowing = new TCoding(ConsistentWithCodeSystemCS.Code_ScarWithShadowing);                            // Builder.cs:349
		public static TCoding Code_SclerosingAdenosis = new TCoding(ConsistentWithCodeSystemCS.Code_SclerosingAdenosis);                          // Builder.cs:349
		public static TCoding Code_SecretoryCalcification = new TCoding(ConsistentWithCodeSystemCS.Code_SecretoryCalcification);                  // Builder.cs:349
		public static TCoding Code_SentinelNode = new TCoding(ConsistentWithCodeSystemCS.Code_SentinelNode);                                      // Builder.cs:349
		public static TCoding Code_Seroma = new TCoding(ConsistentWithCodeSystemCS.Code_Seroma);                                                  // Builder.cs:349
		public static TCoding Code_SkinLesion = new TCoding(ConsistentWithCodeSystemCS.Code_SkinLesion);                                          // Builder.cs:349
		public static TCoding Code_Surgery = new TCoding(ConsistentWithCodeSystemCS.Code_Surgery);                                                // Builder.cs:349
		public static TCoding Code_Trauma = new TCoding(ConsistentWithCodeSystemCS.Code_Trauma);                                                  // Builder.cs:349
		public static TCoding Code_VascularCalcifications = new TCoding(ConsistentWithCodeSystemCS.Code_VascularCalcifications);                  // Builder.cs:349
		public static TCoding Code_VenousStasis = new TCoding(ConsistentWithCodeSystemCS.Code_VenousStasis);                                      // Builder.cs:349
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:335
		{                                                                                                                                         // Builder.cs:336
		    yield return Code_Abscess;                                                                                                            // Builder.cs:352
		    yield return Code_Angiolipoma;                                                                                                        // Builder.cs:352
		    yield return Code_ApocrineMetaplasia;                                                                                                 // Builder.cs:352
		    yield return Code_Artifact;                                                                                                           // Builder.cs:352
		    yield return Code_AtypicalHyperplasia;                                                                                                // Builder.cs:352
		    yield return Code_AxillaryLymphNode;                                                                                                  // Builder.cs:352
		    yield return Code_Carcinoma;                                                                                                          // Builder.cs:352
		    yield return Code_CarcinomaKnown;                                                                                                     // Builder.cs:352
		    yield return Code_ClusterOfCysts;                                                                                                     // Builder.cs:352
		    yield return Code_Cyst;                                                                                                               // Builder.cs:352
		    yield return Code_CystComplex;                                                                                                        // Builder.cs:352
		    yield return Code_CystComplicated;                                                                                                    // Builder.cs:352
		    yield return Code_CystOil;                                                                                                            // Builder.cs:352
		    yield return Code_CystSebaceous;                                                                                                      // Builder.cs:352
		    yield return Code_CystSimple;                                                                                                         // Builder.cs:352
		    yield return Code_CystsComplex;                                                                                                       // Builder.cs:352
		    yield return Code_CystsComplicated;                                                                                                   // Builder.cs:352
		    yield return Code_CystsMicroClustered;                                                                                                // Builder.cs:352
		    yield return Code_DCIS;                                                                                                               // Builder.cs:352
		    yield return Code_Debris;                                                                                                             // Builder.cs:352
		    yield return Code_Deodorant;                                                                                                          // Builder.cs:352
		    yield return Code_DermalCalcification;                                                                                                // Builder.cs:352
		    yield return Code_DuctEctasia;                                                                                                        // Builder.cs:352
		    yield return Code_Edema;                                                                                                              // Builder.cs:352
		    yield return Code_FatLobule;                                                                                                          // Builder.cs:352
		    yield return Code_FatNecrosis;                                                                                                        // Builder.cs:352
		    yield return Code_Fibroadenolipoma;                                                                                                   // Builder.cs:352
		    yield return Code_Fibroadenoma;                                                                                                       // Builder.cs:352
		    yield return Code_FibroadenomaDegenerating;                                                                                           // Builder.cs:352
		    yield return Code_FibrocysticChange;                                                                                                  // Builder.cs:352
		    yield return Code_FibroglandularTissue;                                                                                               // Builder.cs:352
		    yield return Code_Fibrosis;                                                                                                           // Builder.cs:352
		    yield return Code_FibrousRidge;                                                                                                       // Builder.cs:352
		    yield return Code_Folliculitis;                                                                                                       // Builder.cs:352
		    yield return Code_Gynecomastia;                                                                                                       // Builder.cs:352
		    yield return Code_Hamartoma;                                                                                                          // Builder.cs:352
		    yield return Code_Hematoma;                                                                                                           // Builder.cs:352
		    yield return Code_HormonalStimulation;                                                                                                // Builder.cs:352
		    yield return Code_IntracysticLesion;                                                                                                  // Builder.cs:352
		    yield return Code_IntramammaryNode;                                                                                                   // Builder.cs:352
		    yield return Code_Lipoma;                                                                                                             // Builder.cs:352
		    yield return Code_LumpectomyCavity;                                                                                                   // Builder.cs:352
		    yield return Code_LumpectomySite;                                                                                                     // Builder.cs:352
		    yield return Code_LymphNode;                                                                                                          // Builder.cs:352
		    yield return Code_LymphNodeEnlarged;                                                                                                  // Builder.cs:352
		    yield return Code_LymphNodeNormal;                                                                                                    // Builder.cs:352
		    yield return Code_LymphNodePathological;                                                                                              // Builder.cs:352
		    yield return Code_MassSolid;                                                                                                          // Builder.cs:352
		    yield return Code_MassSolidWTumorVasc;                                                                                                // Builder.cs:352
		    yield return Code_Mastitis;                                                                                                           // Builder.cs:352
		    yield return Code_MilkOfCalcium;                                                                                                      // Builder.cs:352
		    yield return Code_MultiFocalCancer;                                                                                                   // Builder.cs:352
		    yield return Code_PapillaryLesion;                                                                                                    // Builder.cs:352
		    yield return Code_Papilloma;                                                                                                          // Builder.cs:352
		    yield return Code_PhyllodesTumor;                                                                                                     // Builder.cs:352
		    yield return Code_PostLumpectomyScar;                                                                                                 // Builder.cs:352
		    yield return Code_PostSurgicalScar;                                                                                                   // Builder.cs:352
		    yield return Code_PreviousBiopsy;                                                                                                     // Builder.cs:352
		    yield return Code_PreviousSurgery;                                                                                                    // Builder.cs:352
		    yield return Code_PreviousTrauma;                                                                                                     // Builder.cs:352
		    yield return Code_RadialScar;                                                                                                         // Builder.cs:352
		    yield return Code_RadiationChanges;                                                                                                   // Builder.cs:352
		    yield return Code_RadiationTherapy;                                                                                                   // Builder.cs:352
		    yield return Code_Scar;                                                                                                               // Builder.cs:352
		    yield return Code_ScarWithShadowing;                                                                                                  // Builder.cs:352
		    yield return Code_SclerosingAdenosis;                                                                                                 // Builder.cs:352
		    yield return Code_SecretoryCalcification;                                                                                             // Builder.cs:352
		    yield return Code_SentinelNode;                                                                                                       // Builder.cs:352
		    yield return Code_Seroma;                                                                                                             // Builder.cs:352
		    yield return Code_SkinLesion;                                                                                                         // Builder.cs:352
		    yield return Code_Surgery;                                                                                                            // Builder.cs:352
		    yield return Code_Trauma;                                                                                                             // Builder.cs:352
		    yield return Code_VascularCalcifications;                                                                                             // Builder.cs:352
		    yield return Code_VenousStasis;                                                                                                       // Builder.cs:352
		}                                                                                                                                         // Builder.cs:358
		//- Methods
	}
}
