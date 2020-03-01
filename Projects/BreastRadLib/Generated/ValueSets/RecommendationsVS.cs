using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class RecommendationsVS
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
		public static TCoding Code_3DImaging = new TCoding(RecommendationsCodeSystemCS.Code_3DImaging);                                           // Builder.cs:347
		public static TCoding Code_3DSpotCC = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotCC);                                             // Builder.cs:347
		public static TCoding Code_3DSpotLM = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotLM);                                             // Builder.cs:347
		public static TCoding Code_3DSpotML = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotML);                                             // Builder.cs:347
		public static TCoding Code_3DSpotMLO = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotMLO);                                           // Builder.cs:347
		public static TCoding Code_AdditionalViews = new TCoding(RecommendationsCodeSystemCS.Code_AdditionalViews);                               // Builder.cs:347
		public static TCoding Code_AddlitionalViewsWithPossibleUltrasound = new TCoding(RecommendationsCodeSystemCS.Code_AddlitionalViewsWithPossibleUltrasound);// Builder.cs:347
		public static TCoding Code_AxillaView = new TCoding(RecommendationsCodeSystemCS.Code_AxillaView);                                         // Builder.cs:347
		public static TCoding Code_AxillaryTailView = new TCoding(RecommendationsCodeSystemCS.Code_AxillaryTailView);                             // Builder.cs:347
		public static TCoding Code_Biopsy = new TCoding(RecommendationsCodeSystemCS.Code_Biopsy);                                                 // Builder.cs:347
		public static TCoding Code_BiopsyBaseOnClinical = new TCoding(RecommendationsCodeSystemCS.Code_BiopsyBaseOnClinical);                     // Builder.cs:347
		public static TCoding Code_CaudocranialView = new TCoding(RecommendationsCodeSystemCS.Code_CaudocranialView);                             // Builder.cs:347
		public static TCoding Code_CCWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_CCWithCompressionView);                   // Builder.cs:347
		public static TCoding Code_CCWithMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_CCWithMagnificationView);               // Builder.cs:347
		public static TCoding Code_CleavageView = new TCoding(RecommendationsCodeSystemCS.Code_CleavageView);                                     // Builder.cs:347
		public static TCoding Code_ClinicalConsultation = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalConsultation);                     // Builder.cs:347
		public static TCoding Code_ClinicalCorrelation = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalCorrelation);                       // Builder.cs:347
		public static TCoding Code_ClinicalFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalFollowUp);                             // Builder.cs:347
		public static TCoding Code_CompareToPriorExams = new TCoding(RecommendationsCodeSystemCS.Code_CompareToPriorExams);                       // Builder.cs:347
		public static TCoding Code_CompressionViews = new TCoding(RecommendationsCodeSystemCS.Code_CompressionViews);                             // Builder.cs:347
		public static TCoding Code_ConeCompression = new TCoding(RecommendationsCodeSystemCS.Code_ConeCompression);                               // Builder.cs:347
		public static TCoding Code_CoreBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_CoreBiopsy);                                         // Builder.cs:347
		public static TCoding Code_CraniocaudalView = new TCoding(RecommendationsCodeSystemCS.Code_CraniocaudalView);                             // Builder.cs:347
		public static TCoding Code_Cryoablation = new TCoding(RecommendationsCodeSystemCS.Code_Cryoablation);                                     // Builder.cs:347
		public static TCoding Code_CystAspiration = new TCoding(RecommendationsCodeSystemCS.Code_CystAspiration);                                 // Builder.cs:347
		public static TCoding Code_CystAspirationForRelief = new TCoding(RecommendationsCodeSystemCS.Code_CystAspirationForRelief);               // Builder.cs:347
		public static TCoding Code_DiagnosticAspiration = new TCoding(RecommendationsCodeSystemCS.Code_DiagnosticAspiration);                     // Builder.cs:347
		public static TCoding Code_DiagnosticMammogram = new TCoding(RecommendationsCodeSystemCS.Code_DiagnosticMammogram);                       // Builder.cs:347
		public static TCoding Code_DrainageTube = new TCoding(RecommendationsCodeSystemCS.Code_DrainageTube);                                     // Builder.cs:347
		public static TCoding Code_Ductography = new TCoding(RecommendationsCodeSystemCS.Code_Ductography);                                       // Builder.cs:347
		public static TCoding Code_ExaggeratedCCViews = new TCoding(RecommendationsCodeSystemCS.Code_ExaggeratedCCViews);                         // Builder.cs:347
		public static TCoding Code_FNABiopsy = new TCoding(RecommendationsCodeSystemCS.Code_FNABiopsy);                                           // Builder.cs:347
		public static TCoding Code_FollowUp = new TCoding(RecommendationsCodeSystemCS.Code_FollowUp);                                             // Builder.cs:347
		public static TCoding Code_Followup3Months = new TCoding(RecommendationsCodeSystemCS.Code_Followup3Months);                               // Builder.cs:347
		public static TCoding Code_Followup6Months = new TCoding(RecommendationsCodeSystemCS.Code_Followup6Months);                               // Builder.cs:347
		public static TCoding Code_IfPreviousShowNoChange = new TCoding(RecommendationsCodeSystemCS.Code_IfPreviousShowNoChange);                 // Builder.cs:347
		public static TCoding Code_LateralMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_LateralMagnificationView);             // Builder.cs:347
		public static TCoding Code_LateralMedialView = new TCoding(RecommendationsCodeSystemCS.Code_LateralMedialView);                           // Builder.cs:347
		public static TCoding Code_LateralView = new TCoding(RecommendationsCodeSystemCS.Code_LateralView);                                       // Builder.cs:347
		public static TCoding Code_LateralWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_LateralWithCompressionView);         // Builder.cs:347
		public static TCoding Code_LateromedialOblique = new TCoding(RecommendationsCodeSystemCS.Code_LateromedialOblique);                       // Builder.cs:347
		public static TCoding Code_LateromedialView = new TCoding(RecommendationsCodeSystemCS.Code_LateromedialView);                             // Builder.cs:347
		public static TCoding Code_LymphNodeAssessment = new TCoding(RecommendationsCodeSystemCS.Code_LymphNodeAssessment);                       // Builder.cs:347
		public static TCoding Code_MagnificationViews = new TCoding(RecommendationsCodeSystemCS.Code_MagnificationViews);                         // Builder.cs:347
		public static TCoding Code_Mammogram = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram);                                           // Builder.cs:347
		public static TCoding Code_Mammogram3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram3MonthFollowUp);               // Builder.cs:347
		public static TCoding Code_Mammogram6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram6MonthFollowUp);               // Builder.cs:347
		public static TCoding Code_MammogramAndUltrasound3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MammogramAndUltrasound3MonthFollowUp);// Builder.cs:347
		public static TCoding Code_MammogramAndUltrasound6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MammogramAndUltrasound6MonthFollowUp);// Builder.cs:347
		public static TCoding Code_MediolateralObliqueView = new TCoding(RecommendationsCodeSystemCS.Code_MediolateralObliqueView);               // Builder.cs:347
		public static TCoding Code_MediolateralView = new TCoding(RecommendationsCodeSystemCS.Code_MediolateralView);                             // Builder.cs:347
		public static TCoding Code_MLOWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_MLOWithCompressionView);                 // Builder.cs:347
		public static TCoding Code_MLOWithMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_MLOWithMagnificationView);             // Builder.cs:347
		public static TCoding Code_MRI = new TCoding(RecommendationsCodeSystemCS.Code_MRI);                                                       // Builder.cs:347
		public static TCoding Code_MRIBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_MRIBiopsy);                                           // Builder.cs:347
		public static TCoding Code_MRIFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MRIFollowUp);                                       // Builder.cs:347
		public static TCoding Code_NeedleLocationAndSurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_NeedleLocationAndSurgicalBiopsy);// Builder.cs:347
		public static TCoding Code_NippleInProfileView = new TCoding(RecommendationsCodeSystemCS.Code_NippleInProfileView);                       // Builder.cs:347
		public static TCoding Code_OffAngleCCView = new TCoding(RecommendationsCodeSystemCS.Code_OffAngleCCView);                                 // Builder.cs:347
		public static TCoding Code_OffAngleMLOView = new TCoding(RecommendationsCodeSystemCS.Code_OffAngleMLOView);                               // Builder.cs:347
		public static TCoding Code_PossStereotacticBx = new TCoding(RecommendationsCodeSystemCS.Code_PossStereotacticBx);                         // Builder.cs:347
		public static TCoding Code_PossibleCoreBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleCoreBiopsy);                         // Builder.cs:347
		public static TCoding Code_PossibleDiagnosticMammogram = new TCoding(RecommendationsCodeSystemCS.Code_PossibleDiagnosticMammogram);       // Builder.cs:347
		public static TCoding Code_PossibleStereotacticVacuumBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleStereotacticVacuumBiopsy);// Builder.cs:347
		public static TCoding Code_PossibleSurgicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_PossibleSurgicalConsult);               // Builder.cs:347
		public static TCoding Code_PossibleSurgicalEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_PossibleSurgicalEvaluation);         // Builder.cs:347
		public static TCoding Code_PossibleUltrasound = new TCoding(RecommendationsCodeSystemCS.Code_PossibleUltrasound);                         // Builder.cs:347
		public static TCoding Code_PossibleUltrasoundGuidedBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleUltrasoundGuidedBiopsy); // Builder.cs:347
		public static TCoding Code_PossibleVacuumBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleVacuumBiopsy);                     // Builder.cs:347
		public static TCoding Code_RepeatCCView = new TCoding(RecommendationsCodeSystemCS.Code_RepeatCCView);                                     // Builder.cs:347
		public static TCoding Code_RepeatMLOView = new TCoding(RecommendationsCodeSystemCS.Code_RepeatMLOView);                                   // Builder.cs:347
		public static TCoding Code_RolledLateralView = new TCoding(RecommendationsCodeSystemCS.Code_RolledLateralView);                           // Builder.cs:347
		public static TCoding Code_RolledMedialView = new TCoding(RecommendationsCodeSystemCS.Code_RolledMedialView);                             // Builder.cs:347
		public static TCoding Code_ScintimammogramGuidedBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_ScintimammogramGuidedBiopsy);       // Builder.cs:347
		public static TCoding Code_Scintimammography = new TCoding(RecommendationsCodeSystemCS.Code_Scintimammography);                           // Builder.cs:347
		public static TCoding Code_SpotCompression = new TCoding(RecommendationsCodeSystemCS.Code_SpotCompression);                               // Builder.cs:347
		public static TCoding Code_SpotMagnificationViews = new TCoding(RecommendationsCodeSystemCS.Code_SpotMagnificationViews);                 // Builder.cs:347
		public static TCoding Code_StereotacticBx = new TCoding(RecommendationsCodeSystemCS.Code_StereotacticBx);                                 // Builder.cs:347
		public static TCoding Code_SuperolateralIOView = new TCoding(RecommendationsCodeSystemCS.Code_SuperolateralIOView);                       // Builder.cs:347
		public static TCoding Code_SurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalBiopsy);                                 // Builder.cs:347
		public static TCoding Code_SurgicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalConsult);                               // Builder.cs:347
		public static TCoding Code_SurgicalConsultAndBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalConsultAndBiopsy);             // Builder.cs:347
		public static TCoding Code_SurgicalEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalEvaluation);                         // Builder.cs:347
		public static TCoding Code_SurgicalExcision = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalExcision);                             // Builder.cs:347
		public static TCoding Code_SurgicalOncologicEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalOncologicEvaluation);       // Builder.cs:347
		public static TCoding Code_SurgicalOncologicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalOncologicalConsult);         // Builder.cs:347
		public static TCoding Code_TangentialView = new TCoding(RecommendationsCodeSystemCS.Code_TangentialView);                                 // Builder.cs:347
		public static TCoding Code_TangentialViews = new TCoding(RecommendationsCodeSystemCS.Code_TangentialViews);                               // Builder.cs:347
		public static TCoding Code_Ultrasound = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound);                                         // Builder.cs:347
		public static TCoding Code_Ultrasound2ndLook = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound2ndLook);                           // Builder.cs:347
		public static TCoding Code_Ultrasound3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound3MonthFollowUp);             // Builder.cs:347
		public static TCoding Code_Ultrasound6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound6MonthFollowUp);             // Builder.cs:347
		public static TCoding Code_UltrasoundGuidedBx = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundGuidedBx);                         // Builder.cs:347
		public static TCoding Code_UltrasoundLocationAndSurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundLocationAndSurgicalBiopsy);// Builder.cs:347
		public static TCoding Code_UltrasoundWithPossibleAddlitonalViews = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundWithPossibleAddlitonalViews);// Builder.cs:347
		public static TCoding Code_UnspecifiedOther = new TCoding(RecommendationsCodeSystemCS.Code_UnspecifiedOther);                             // Builder.cs:347
		public static TCoding Code_VacuumBx = new TCoding(RecommendationsCodeSystemCS.Code_VacuumBx);                                             // Builder.cs:347
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // Builder.cs:333
		{                                                                                                                                         // Builder.cs:334
		    yield return Code_3DImaging;                                                                                                          // Builder.cs:350
		    yield return Code_3DSpotCC;                                                                                                           // Builder.cs:350
		    yield return Code_3DSpotLM;                                                                                                           // Builder.cs:350
		    yield return Code_3DSpotML;                                                                                                           // Builder.cs:350
		    yield return Code_3DSpotMLO;                                                                                                          // Builder.cs:350
		    yield return Code_AdditionalViews;                                                                                                    // Builder.cs:350
		    yield return Code_AddlitionalViewsWithPossibleUltrasound;                                                                             // Builder.cs:350
		    yield return Code_AxillaView;                                                                                                         // Builder.cs:350
		    yield return Code_AxillaryTailView;                                                                                                   // Builder.cs:350
		    yield return Code_Biopsy;                                                                                                             // Builder.cs:350
		    yield return Code_BiopsyBaseOnClinical;                                                                                               // Builder.cs:350
		    yield return Code_CaudocranialView;                                                                                                   // Builder.cs:350
		    yield return Code_CCWithCompressionView;                                                                                              // Builder.cs:350
		    yield return Code_CCWithMagnificationView;                                                                                            // Builder.cs:350
		    yield return Code_CleavageView;                                                                                                       // Builder.cs:350
		    yield return Code_ClinicalConsultation;                                                                                               // Builder.cs:350
		    yield return Code_ClinicalCorrelation;                                                                                                // Builder.cs:350
		    yield return Code_ClinicalFollowUp;                                                                                                   // Builder.cs:350
		    yield return Code_CompareToPriorExams;                                                                                                // Builder.cs:350
		    yield return Code_CompressionViews;                                                                                                   // Builder.cs:350
		    yield return Code_ConeCompression;                                                                                                    // Builder.cs:350
		    yield return Code_CoreBiopsy;                                                                                                         // Builder.cs:350
		    yield return Code_CraniocaudalView;                                                                                                   // Builder.cs:350
		    yield return Code_Cryoablation;                                                                                                       // Builder.cs:350
		    yield return Code_CystAspiration;                                                                                                     // Builder.cs:350
		    yield return Code_CystAspirationForRelief;                                                                                            // Builder.cs:350
		    yield return Code_DiagnosticAspiration;                                                                                               // Builder.cs:350
		    yield return Code_DiagnosticMammogram;                                                                                                // Builder.cs:350
		    yield return Code_DrainageTube;                                                                                                       // Builder.cs:350
		    yield return Code_Ductography;                                                                                                        // Builder.cs:350
		    yield return Code_ExaggeratedCCViews;                                                                                                 // Builder.cs:350
		    yield return Code_FNABiopsy;                                                                                                          // Builder.cs:350
		    yield return Code_FollowUp;                                                                                                           // Builder.cs:350
		    yield return Code_Followup3Months;                                                                                                    // Builder.cs:350
		    yield return Code_Followup6Months;                                                                                                    // Builder.cs:350
		    yield return Code_IfPreviousShowNoChange;                                                                                             // Builder.cs:350
		    yield return Code_LateralMagnificationView;                                                                                           // Builder.cs:350
		    yield return Code_LateralMedialView;                                                                                                  // Builder.cs:350
		    yield return Code_LateralView;                                                                                                        // Builder.cs:350
		    yield return Code_LateralWithCompressionView;                                                                                         // Builder.cs:350
		    yield return Code_LateromedialOblique;                                                                                                // Builder.cs:350
		    yield return Code_LateromedialView;                                                                                                   // Builder.cs:350
		    yield return Code_LymphNodeAssessment;                                                                                                // Builder.cs:350
		    yield return Code_MagnificationViews;                                                                                                 // Builder.cs:350
		    yield return Code_Mammogram;                                                                                                          // Builder.cs:350
		    yield return Code_Mammogram3MonthFollowUp;                                                                                            // Builder.cs:350
		    yield return Code_Mammogram6MonthFollowUp;                                                                                            // Builder.cs:350
		    yield return Code_MammogramAndUltrasound3MonthFollowUp;                                                                               // Builder.cs:350
		    yield return Code_MammogramAndUltrasound6MonthFollowUp;                                                                               // Builder.cs:350
		    yield return Code_MediolateralObliqueView;                                                                                            // Builder.cs:350
		    yield return Code_MediolateralView;                                                                                                   // Builder.cs:350
		    yield return Code_MLOWithCompressionView;                                                                                             // Builder.cs:350
		    yield return Code_MLOWithMagnificationView;                                                                                           // Builder.cs:350
		    yield return Code_MRI;                                                                                                                // Builder.cs:350
		    yield return Code_MRIBiopsy;                                                                                                          // Builder.cs:350
		    yield return Code_MRIFollowUp;                                                                                                        // Builder.cs:350
		    yield return Code_NeedleLocationAndSurgicalBiopsy;                                                                                    // Builder.cs:350
		    yield return Code_NippleInProfileView;                                                                                                // Builder.cs:350
		    yield return Code_OffAngleCCView;                                                                                                     // Builder.cs:350
		    yield return Code_OffAngleMLOView;                                                                                                    // Builder.cs:350
		    yield return Code_PossStereotacticBx;                                                                                                 // Builder.cs:350
		    yield return Code_PossibleCoreBiopsy;                                                                                                 // Builder.cs:350
		    yield return Code_PossibleDiagnosticMammogram;                                                                                        // Builder.cs:350
		    yield return Code_PossibleStereotacticVacuumBiopsy;                                                                                   // Builder.cs:350
		    yield return Code_PossibleSurgicalConsult;                                                                                            // Builder.cs:350
		    yield return Code_PossibleSurgicalEvaluation;                                                                                         // Builder.cs:350
		    yield return Code_PossibleUltrasound;                                                                                                 // Builder.cs:350
		    yield return Code_PossibleUltrasoundGuidedBiopsy;                                                                                     // Builder.cs:350
		    yield return Code_PossibleVacuumBiopsy;                                                                                               // Builder.cs:350
		    yield return Code_RepeatCCView;                                                                                                       // Builder.cs:350
		    yield return Code_RepeatMLOView;                                                                                                      // Builder.cs:350
		    yield return Code_RolledLateralView;                                                                                                  // Builder.cs:350
		    yield return Code_RolledMedialView;                                                                                                   // Builder.cs:350
		    yield return Code_ScintimammogramGuidedBiopsy;                                                                                        // Builder.cs:350
		    yield return Code_Scintimammography;                                                                                                  // Builder.cs:350
		    yield return Code_SpotCompression;                                                                                                    // Builder.cs:350
		    yield return Code_SpotMagnificationViews;                                                                                             // Builder.cs:350
		    yield return Code_StereotacticBx;                                                                                                     // Builder.cs:350
		    yield return Code_SuperolateralIOView;                                                                                                // Builder.cs:350
		    yield return Code_SurgicalBiopsy;                                                                                                     // Builder.cs:350
		    yield return Code_SurgicalConsult;                                                                                                    // Builder.cs:350
		    yield return Code_SurgicalConsultAndBiopsy;                                                                                           // Builder.cs:350
		    yield return Code_SurgicalEvaluation;                                                                                                 // Builder.cs:350
		    yield return Code_SurgicalExcision;                                                                                                   // Builder.cs:350
		    yield return Code_SurgicalOncologicEvaluation;                                                                                        // Builder.cs:350
		    yield return Code_SurgicalOncologicalConsult;                                                                                         // Builder.cs:350
		    yield return Code_TangentialView;                                                                                                     // Builder.cs:350
		    yield return Code_TangentialViews;                                                                                                    // Builder.cs:350
		    yield return Code_Ultrasound;                                                                                                         // Builder.cs:350
		    yield return Code_Ultrasound2ndLook;                                                                                                  // Builder.cs:350
		    yield return Code_Ultrasound3MonthFollowUp;                                                                                           // Builder.cs:350
		    yield return Code_Ultrasound6MonthFollowUp;                                                                                           // Builder.cs:350
		    yield return Code_UltrasoundGuidedBx;                                                                                                 // Builder.cs:350
		    yield return Code_UltrasoundLocationAndSurgicalBiopsy;                                                                                // Builder.cs:350
		    yield return Code_UltrasoundWithPossibleAddlitonalViews;                                                                              // Builder.cs:350
		    yield return Code_UnspecifiedOther;                                                                                                   // Builder.cs:350
		    yield return Code_VacuumBx;                                                                                                           // Builder.cs:350
		}                                                                                                                                         // Builder.cs:356
		//- Methods
	}
}
