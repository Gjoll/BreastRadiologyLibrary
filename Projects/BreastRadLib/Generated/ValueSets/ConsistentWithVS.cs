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
		public static TCoding Code_Abscess = new TCoding(ConsistentWithCodeSystemCS.Code_Abscess);                                                // CSBuilder.cs:322
		public static TCoding Code_Angiolipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Angiolipoma);                                        // CSBuilder.cs:322
		public static TCoding Code_ApocrineMetaplasia = new TCoding(ConsistentWithCodeSystemCS.Code_ApocrineMetaplasia);                          // CSBuilder.cs:322
		public static TCoding Code_Artifact = new TCoding(ConsistentWithCodeSystemCS.Code_Artifact);                                              // CSBuilder.cs:322
		public static TCoding Code_AtypicalHyperplasia = new TCoding(ConsistentWithCodeSystemCS.Code_AtypicalHyperplasia);                        // CSBuilder.cs:322
		public static TCoding Code_AxillaryLymphNode = new TCoding(ConsistentWithCodeSystemCS.Code_AxillaryLymphNode);                            // CSBuilder.cs:322
		public static TCoding Code_Carcinoma = new TCoding(ConsistentWithCodeSystemCS.Code_Carcinoma);                                            // CSBuilder.cs:322
		public static TCoding Code_CarcinomaKnown = new TCoding(ConsistentWithCodeSystemCS.Code_CarcinomaKnown);                                  // CSBuilder.cs:322
		public static TCoding Code_ClusterOfCysts = new TCoding(ConsistentWithCodeSystemCS.Code_ClusterOfCysts);                                  // CSBuilder.cs:322
		public static TCoding Code_Cyst = new TCoding(ConsistentWithCodeSystemCS.Code_Cyst);                                                      // CSBuilder.cs:322
		public static TCoding Code_CystComplex = new TCoding(ConsistentWithCodeSystemCS.Code_CystComplex);                                        // CSBuilder.cs:322
		public static TCoding Code_CystComplicated = new TCoding(ConsistentWithCodeSystemCS.Code_CystComplicated);                                // CSBuilder.cs:322
		public static TCoding Code_CystOil = new TCoding(ConsistentWithCodeSystemCS.Code_CystOil);                                                // CSBuilder.cs:322
		public static TCoding Code_CystSebaceous = new TCoding(ConsistentWithCodeSystemCS.Code_CystSebaceous);                                    // CSBuilder.cs:322
		public static TCoding Code_CystSimple = new TCoding(ConsistentWithCodeSystemCS.Code_CystSimple);                                          // CSBuilder.cs:322
		public static TCoding Code_CystsComplex = new TCoding(ConsistentWithCodeSystemCS.Code_CystsComplex);                                      // CSBuilder.cs:322
		public static TCoding Code_CystsComplicated = new TCoding(ConsistentWithCodeSystemCS.Code_CystsComplicated);                              // CSBuilder.cs:322
		public static TCoding Code_CystsMicroClustered = new TCoding(ConsistentWithCodeSystemCS.Code_CystsMicroClustered);                        // CSBuilder.cs:322
		public static TCoding Code_DCIS = new TCoding(ConsistentWithCodeSystemCS.Code_DCIS);                                                      // CSBuilder.cs:322
		public static TCoding Code_Debris = new TCoding(ConsistentWithCodeSystemCS.Code_Debris);                                                  // CSBuilder.cs:322
		public static TCoding Code_Deodorant = new TCoding(ConsistentWithCodeSystemCS.Code_Deodorant);                                            // CSBuilder.cs:322
		public static TCoding Code_DermalCalcification = new TCoding(ConsistentWithCodeSystemCS.Code_DermalCalcification);                        // CSBuilder.cs:322
		public static TCoding Code_DuctEctasia = new TCoding(ConsistentWithCodeSystemCS.Code_DuctEctasia);                                        // CSBuilder.cs:322
		public static TCoding Code_Edema = new TCoding(ConsistentWithCodeSystemCS.Code_Edema);                                                    // CSBuilder.cs:322
		public static TCoding Code_FatLobule = new TCoding(ConsistentWithCodeSystemCS.Code_FatLobule);                                            // CSBuilder.cs:322
		public static TCoding Code_FatNecrosis = new TCoding(ConsistentWithCodeSystemCS.Code_FatNecrosis);                                        // CSBuilder.cs:322
		public static TCoding Code_Fibroadenolipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Fibroadenolipoma);                              // CSBuilder.cs:322
		public static TCoding Code_Fibroadenoma = new TCoding(ConsistentWithCodeSystemCS.Code_Fibroadenoma);                                      // CSBuilder.cs:322
		public static TCoding Code_FibroadenomaDegenerating = new TCoding(ConsistentWithCodeSystemCS.Code_FibroadenomaDegenerating);              // CSBuilder.cs:322
		public static TCoding Code_FibrocysticChange = new TCoding(ConsistentWithCodeSystemCS.Code_FibrocysticChange);                            // CSBuilder.cs:322
		public static TCoding Code_FibroglandularTissue = new TCoding(ConsistentWithCodeSystemCS.Code_FibroglandularTissue);                      // CSBuilder.cs:322
		public static TCoding Code_Fibrosis = new TCoding(ConsistentWithCodeSystemCS.Code_Fibrosis);                                              // CSBuilder.cs:322
		public static TCoding Code_FibrousRidge = new TCoding(ConsistentWithCodeSystemCS.Code_FibrousRidge);                                      // CSBuilder.cs:322
		public static TCoding Code_Folliculitis = new TCoding(ConsistentWithCodeSystemCS.Code_Folliculitis);                                      // CSBuilder.cs:322
		public static TCoding Code_Gynecomastia = new TCoding(ConsistentWithCodeSystemCS.Code_Gynecomastia);                                      // CSBuilder.cs:322
		public static TCoding Code_Hamartoma = new TCoding(ConsistentWithCodeSystemCS.Code_Hamartoma);                                            // CSBuilder.cs:322
		public static TCoding Code_Hematoma = new TCoding(ConsistentWithCodeSystemCS.Code_Hematoma);                                              // CSBuilder.cs:322
		public static TCoding Code_HormonalStimulation = new TCoding(ConsistentWithCodeSystemCS.Code_HormonalStimulation);                        // CSBuilder.cs:322
		public static TCoding Code_IntracysticLesion = new TCoding(ConsistentWithCodeSystemCS.Code_IntracysticLesion);                            // CSBuilder.cs:322
		public static TCoding Code_IntramammaryNode = new TCoding(ConsistentWithCodeSystemCS.Code_IntramammaryNode);                              // CSBuilder.cs:322
		public static TCoding Code_Lipoma = new TCoding(ConsistentWithCodeSystemCS.Code_Lipoma);                                                  // CSBuilder.cs:322
		public static TCoding Code_LumpectomyCavity = new TCoding(ConsistentWithCodeSystemCS.Code_LumpectomyCavity);                              // CSBuilder.cs:322
		public static TCoding Code_LumpectomySite = new TCoding(ConsistentWithCodeSystemCS.Code_LumpectomySite);                                  // CSBuilder.cs:322
		public static TCoding Code_LymphNode = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNode);                                            // CSBuilder.cs:322
		public static TCoding Code_LymphNodeEnlarged = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodeEnlarged);                            // CSBuilder.cs:322
		public static TCoding Code_LymphNodeNormal = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodeNormal);                                // CSBuilder.cs:322
		public static TCoding Code_LymphNodePathological = new TCoding(ConsistentWithCodeSystemCS.Code_LymphNodePathological);                    // CSBuilder.cs:322
		public static TCoding Code_MassSolid = new TCoding(ConsistentWithCodeSystemCS.Code_MassSolid);                                            // CSBuilder.cs:322
		public static TCoding Code_MassSolidWTumorVasc = new TCoding(ConsistentWithCodeSystemCS.Code_MassSolidWTumorVasc);                        // CSBuilder.cs:322
		public static TCoding Code_Mastitis = new TCoding(ConsistentWithCodeSystemCS.Code_Mastitis);                                              // CSBuilder.cs:322
		public static TCoding Code_MilkOfCalcium = new TCoding(ConsistentWithCodeSystemCS.Code_MilkOfCalcium);                                    // CSBuilder.cs:322
		public static TCoding Code_MultiFocalCancer = new TCoding(ConsistentWithCodeSystemCS.Code_MultiFocalCancer);                              // CSBuilder.cs:322
		public static TCoding Code_PapillaryLesion = new TCoding(ConsistentWithCodeSystemCS.Code_PapillaryLesion);                                // CSBuilder.cs:322
		public static TCoding Code_Papilloma = new TCoding(ConsistentWithCodeSystemCS.Code_Papilloma);                                            // CSBuilder.cs:322
		public static TCoding Code_PhyllodesTumor = new TCoding(ConsistentWithCodeSystemCS.Code_PhyllodesTumor);                                  // CSBuilder.cs:322
		public static TCoding Code_PostLumpectomyScar = new TCoding(ConsistentWithCodeSystemCS.Code_PostLumpectomyScar);                          // CSBuilder.cs:322
		public static TCoding Code_PostSurgicalScar = new TCoding(ConsistentWithCodeSystemCS.Code_PostSurgicalScar);                              // CSBuilder.cs:322
		public static TCoding Code_PreviousBiopsy = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousBiopsy);                                  // CSBuilder.cs:322
		public static TCoding Code_PreviousSurgery = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousSurgery);                                // CSBuilder.cs:322
		public static TCoding Code_PreviousTrauma = new TCoding(ConsistentWithCodeSystemCS.Code_PreviousTrauma);                                  // CSBuilder.cs:322
		public static TCoding Code_RadialScar = new TCoding(ConsistentWithCodeSystemCS.Code_RadialScar);                                          // CSBuilder.cs:322
		public static TCoding Code_RadiationChanges = new TCoding(ConsistentWithCodeSystemCS.Code_RadiationChanges);                              // CSBuilder.cs:322
		public static TCoding Code_RadiationTherapy = new TCoding(ConsistentWithCodeSystemCS.Code_RadiationTherapy);                              // CSBuilder.cs:322
		public static TCoding Code_Scar = new TCoding(ConsistentWithCodeSystemCS.Code_Scar);                                                      // CSBuilder.cs:322
		public static TCoding Code_ScarWithShadowing = new TCoding(ConsistentWithCodeSystemCS.Code_ScarWithShadowing);                            // CSBuilder.cs:322
		public static TCoding Code_SclerosingAdenosis = new TCoding(ConsistentWithCodeSystemCS.Code_SclerosingAdenosis);                          // CSBuilder.cs:322
		public static TCoding Code_SecretoryCalcification = new TCoding(ConsistentWithCodeSystemCS.Code_SecretoryCalcification);                  // CSBuilder.cs:322
		public static TCoding Code_SentinelNode = new TCoding(ConsistentWithCodeSystemCS.Code_SentinelNode);                                      // CSBuilder.cs:322
		public static TCoding Code_Seroma = new TCoding(ConsistentWithCodeSystemCS.Code_Seroma);                                                  // CSBuilder.cs:322
		public static TCoding Code_SkinLesion = new TCoding(ConsistentWithCodeSystemCS.Code_SkinLesion);                                          // CSBuilder.cs:322
		public static TCoding Code_Surgery = new TCoding(ConsistentWithCodeSystemCS.Code_Surgery);                                                // CSBuilder.cs:322
		public static TCoding Code_Trauma = new TCoding(ConsistentWithCodeSystemCS.Code_Trauma);                                                  // CSBuilder.cs:322
		public static TCoding Code_VascularCalcifications = new TCoding(ConsistentWithCodeSystemCS.Code_VascularCalcifications);                  // CSBuilder.cs:322
		public static TCoding Code_VenousStasis = new TCoding(ConsistentWithCodeSystemCS.Code_VenousStasis);                                      // CSBuilder.cs:322
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:307
		{                                                                                                                                         // CSBuilder.cs:308
		    yield return Code_Abscess;                                                                                                            // CSBuilder.cs:325
		    yield return Code_Angiolipoma;                                                                                                        // CSBuilder.cs:325
		    yield return Code_ApocrineMetaplasia;                                                                                                 // CSBuilder.cs:325
		    yield return Code_Artifact;                                                                                                           // CSBuilder.cs:325
		    yield return Code_AtypicalHyperplasia;                                                                                                // CSBuilder.cs:325
		    yield return Code_AxillaryLymphNode;                                                                                                  // CSBuilder.cs:325
		    yield return Code_Carcinoma;                                                                                                          // CSBuilder.cs:325
		    yield return Code_CarcinomaKnown;                                                                                                     // CSBuilder.cs:325
		    yield return Code_ClusterOfCysts;                                                                                                     // CSBuilder.cs:325
		    yield return Code_Cyst;                                                                                                               // CSBuilder.cs:325
		    yield return Code_CystComplex;                                                                                                        // CSBuilder.cs:325
		    yield return Code_CystComplicated;                                                                                                    // CSBuilder.cs:325
		    yield return Code_CystOil;                                                                                                            // CSBuilder.cs:325
		    yield return Code_CystSebaceous;                                                                                                      // CSBuilder.cs:325
		    yield return Code_CystSimple;                                                                                                         // CSBuilder.cs:325
		    yield return Code_CystsComplex;                                                                                                       // CSBuilder.cs:325
		    yield return Code_CystsComplicated;                                                                                                   // CSBuilder.cs:325
		    yield return Code_CystsMicroClustered;                                                                                                // CSBuilder.cs:325
		    yield return Code_DCIS;                                                                                                               // CSBuilder.cs:325
		    yield return Code_Debris;                                                                                                             // CSBuilder.cs:325
		    yield return Code_Deodorant;                                                                                                          // CSBuilder.cs:325
		    yield return Code_DermalCalcification;                                                                                                // CSBuilder.cs:325
		    yield return Code_DuctEctasia;                                                                                                        // CSBuilder.cs:325
		    yield return Code_Edema;                                                                                                              // CSBuilder.cs:325
		    yield return Code_FatLobule;                                                                                                          // CSBuilder.cs:325
		    yield return Code_FatNecrosis;                                                                                                        // CSBuilder.cs:325
		    yield return Code_Fibroadenolipoma;                                                                                                   // CSBuilder.cs:325
		    yield return Code_Fibroadenoma;                                                                                                       // CSBuilder.cs:325
		    yield return Code_FibroadenomaDegenerating;                                                                                           // CSBuilder.cs:325
		    yield return Code_FibrocysticChange;                                                                                                  // CSBuilder.cs:325
		    yield return Code_FibroglandularTissue;                                                                                               // CSBuilder.cs:325
		    yield return Code_Fibrosis;                                                                                                           // CSBuilder.cs:325
		    yield return Code_FibrousRidge;                                                                                                       // CSBuilder.cs:325
		    yield return Code_Folliculitis;                                                                                                       // CSBuilder.cs:325
		    yield return Code_Gynecomastia;                                                                                                       // CSBuilder.cs:325
		    yield return Code_Hamartoma;                                                                                                          // CSBuilder.cs:325
		    yield return Code_Hematoma;                                                                                                           // CSBuilder.cs:325
		    yield return Code_HormonalStimulation;                                                                                                // CSBuilder.cs:325
		    yield return Code_IntracysticLesion;                                                                                                  // CSBuilder.cs:325
		    yield return Code_IntramammaryNode;                                                                                                   // CSBuilder.cs:325
		    yield return Code_Lipoma;                                                                                                             // CSBuilder.cs:325
		    yield return Code_LumpectomyCavity;                                                                                                   // CSBuilder.cs:325
		    yield return Code_LumpectomySite;                                                                                                     // CSBuilder.cs:325
		    yield return Code_LymphNode;                                                                                                          // CSBuilder.cs:325
		    yield return Code_LymphNodeEnlarged;                                                                                                  // CSBuilder.cs:325
		    yield return Code_LymphNodeNormal;                                                                                                    // CSBuilder.cs:325
		    yield return Code_LymphNodePathological;                                                                                              // CSBuilder.cs:325
		    yield return Code_MassSolid;                                                                                                          // CSBuilder.cs:325
		    yield return Code_MassSolidWTumorVasc;                                                                                                // CSBuilder.cs:325
		    yield return Code_Mastitis;                                                                                                           // CSBuilder.cs:325
		    yield return Code_MilkOfCalcium;                                                                                                      // CSBuilder.cs:325
		    yield return Code_MultiFocalCancer;                                                                                                   // CSBuilder.cs:325
		    yield return Code_PapillaryLesion;                                                                                                    // CSBuilder.cs:325
		    yield return Code_Papilloma;                                                                                                          // CSBuilder.cs:325
		    yield return Code_PhyllodesTumor;                                                                                                     // CSBuilder.cs:325
		    yield return Code_PostLumpectomyScar;                                                                                                 // CSBuilder.cs:325
		    yield return Code_PostSurgicalScar;                                                                                                   // CSBuilder.cs:325
		    yield return Code_PreviousBiopsy;                                                                                                     // CSBuilder.cs:325
		    yield return Code_PreviousSurgery;                                                                                                    // CSBuilder.cs:325
		    yield return Code_PreviousTrauma;                                                                                                     // CSBuilder.cs:325
		    yield return Code_RadialScar;                                                                                                         // CSBuilder.cs:325
		    yield return Code_RadiationChanges;                                                                                                   // CSBuilder.cs:325
		    yield return Code_RadiationTherapy;                                                                                                   // CSBuilder.cs:325
		    yield return Code_Scar;                                                                                                               // CSBuilder.cs:325
		    yield return Code_ScarWithShadowing;                                                                                                  // CSBuilder.cs:325
		    yield return Code_SclerosingAdenosis;                                                                                                 // CSBuilder.cs:325
		    yield return Code_SecretoryCalcification;                                                                                             // CSBuilder.cs:325
		    yield return Code_SentinelNode;                                                                                                       // CSBuilder.cs:325
		    yield return Code_Seroma;                                                                                                             // CSBuilder.cs:325
		    yield return Code_SkinLesion;                                                                                                         // CSBuilder.cs:325
		    yield return Code_Surgery;                                                                                                            // CSBuilder.cs:325
		    yield return Code_Trauma;                                                                                                             // CSBuilder.cs:325
		    yield return Code_VascularCalcifications;                                                                                             // CSBuilder.cs:325
		    yield return Code_VenousStasis;                                                                                                       // CSBuilder.cs:325
		}                                                                                                                                         // CSBuilder.cs:331
		//- Methods
	}
}
