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
		public static TCoding Code_3DImaging = new TCoding(RecommendationsCodeSystemCS.Code_3DImaging);                                           // CSBuilder.cs:320
		public static TCoding Code_3DSpotCC = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotCC);                                             // CSBuilder.cs:320
		public static TCoding Code_3DSpotLM = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotLM);                                             // CSBuilder.cs:320
		public static TCoding Code_3DSpotML = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotML);                                             // CSBuilder.cs:320
		public static TCoding Code_3DSpotMLO = new TCoding(RecommendationsCodeSystemCS.Code_3DSpotMLO);                                           // CSBuilder.cs:320
		public static TCoding Code_AdditionalViews = new TCoding(RecommendationsCodeSystemCS.Code_AdditionalViews);                               // CSBuilder.cs:320
		public static TCoding Code_AddlitionalViewsWithPossibleUltrasound = new TCoding(RecommendationsCodeSystemCS.Code_AddlitionalViewsWithPossibleUltrasound);// CSBuilder.cs:320
		public static TCoding Code_AxillaView = new TCoding(RecommendationsCodeSystemCS.Code_AxillaView);                                         // CSBuilder.cs:320
		public static TCoding Code_AxillaryTailView = new TCoding(RecommendationsCodeSystemCS.Code_AxillaryTailView);                             // CSBuilder.cs:320
		public static TCoding Code_Biopsy = new TCoding(RecommendationsCodeSystemCS.Code_Biopsy);                                                 // CSBuilder.cs:320
		public static TCoding Code_BiopsyBaseOnClinical = new TCoding(RecommendationsCodeSystemCS.Code_BiopsyBaseOnClinical);                     // CSBuilder.cs:320
		public static TCoding Code_CaudocranialView = new TCoding(RecommendationsCodeSystemCS.Code_CaudocranialView);                             // CSBuilder.cs:320
		public static TCoding Code_CCWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_CCWithCompressionView);                   // CSBuilder.cs:320
		public static TCoding Code_CCWithMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_CCWithMagnificationView);               // CSBuilder.cs:320
		public static TCoding Code_CleavageView = new TCoding(RecommendationsCodeSystemCS.Code_CleavageView);                                     // CSBuilder.cs:320
		public static TCoding Code_ClinicalConsultation = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalConsultation);                     // CSBuilder.cs:320
		public static TCoding Code_ClinicalCorrelation = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalCorrelation);                       // CSBuilder.cs:320
		public static TCoding Code_ClinicalFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_ClinicalFollowUp);                             // CSBuilder.cs:320
		public static TCoding Code_CompareToPriorExams = new TCoding(RecommendationsCodeSystemCS.Code_CompareToPriorExams);                       // CSBuilder.cs:320
		public static TCoding Code_CompressionViews = new TCoding(RecommendationsCodeSystemCS.Code_CompressionViews);                             // CSBuilder.cs:320
		public static TCoding Code_ConeCompression = new TCoding(RecommendationsCodeSystemCS.Code_ConeCompression);                               // CSBuilder.cs:320
		public static TCoding Code_CoreBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_CoreBiopsy);                                         // CSBuilder.cs:320
		public static TCoding Code_CraniocaudalView = new TCoding(RecommendationsCodeSystemCS.Code_CraniocaudalView);                             // CSBuilder.cs:320
		public static TCoding Code_Cryoablation = new TCoding(RecommendationsCodeSystemCS.Code_Cryoablation);                                     // CSBuilder.cs:320
		public static TCoding Code_CystAspiration = new TCoding(RecommendationsCodeSystemCS.Code_CystAspiration);                                 // CSBuilder.cs:320
		public static TCoding Code_CystAspirationForRelief = new TCoding(RecommendationsCodeSystemCS.Code_CystAspirationForRelief);               // CSBuilder.cs:320
		public static TCoding Code_DiagnosticAspiration = new TCoding(RecommendationsCodeSystemCS.Code_DiagnosticAspiration);                     // CSBuilder.cs:320
		public static TCoding Code_DiagnosticMammogram = new TCoding(RecommendationsCodeSystemCS.Code_DiagnosticMammogram);                       // CSBuilder.cs:320
		public static TCoding Code_DrainageTube = new TCoding(RecommendationsCodeSystemCS.Code_DrainageTube);                                     // CSBuilder.cs:320
		public static TCoding Code_Ductography = new TCoding(RecommendationsCodeSystemCS.Code_Ductography);                                       // CSBuilder.cs:320
		public static TCoding Code_ExaggeratedCCViews = new TCoding(RecommendationsCodeSystemCS.Code_ExaggeratedCCViews);                         // CSBuilder.cs:320
		public static TCoding Code_FNABiopsy = new TCoding(RecommendationsCodeSystemCS.Code_FNABiopsy);                                           // CSBuilder.cs:320
		public static TCoding Code_FollowUp = new TCoding(RecommendationsCodeSystemCS.Code_FollowUp);                                             // CSBuilder.cs:320
		public static TCoding Code_Followup3Months = new TCoding(RecommendationsCodeSystemCS.Code_Followup3Months);                               // CSBuilder.cs:320
		public static TCoding Code_Followup6Months = new TCoding(RecommendationsCodeSystemCS.Code_Followup6Months);                               // CSBuilder.cs:320
		public static TCoding Code_IfPreviousShowNoChange = new TCoding(RecommendationsCodeSystemCS.Code_IfPreviousShowNoChange);                 // CSBuilder.cs:320
		public static TCoding Code_LateralMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_LateralMagnificationView);             // CSBuilder.cs:320
		public static TCoding Code_LateralMedialView = new TCoding(RecommendationsCodeSystemCS.Code_LateralMedialView);                           // CSBuilder.cs:320
		public static TCoding Code_LateralView = new TCoding(RecommendationsCodeSystemCS.Code_LateralView);                                       // CSBuilder.cs:320
		public static TCoding Code_LateralWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_LateralWithCompressionView);         // CSBuilder.cs:320
		public static TCoding Code_LateromedialOblique = new TCoding(RecommendationsCodeSystemCS.Code_LateromedialOblique);                       // CSBuilder.cs:320
		public static TCoding Code_LateromedialView = new TCoding(RecommendationsCodeSystemCS.Code_LateromedialView);                             // CSBuilder.cs:320
		public static TCoding Code_LymphNodeAssessment = new TCoding(RecommendationsCodeSystemCS.Code_LymphNodeAssessment);                       // CSBuilder.cs:320
		public static TCoding Code_MagnificationViews = new TCoding(RecommendationsCodeSystemCS.Code_MagnificationViews);                         // CSBuilder.cs:320
		public static TCoding Code_Mammogram = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram);                                           // CSBuilder.cs:320
		public static TCoding Code_Mammogram3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram3MonthFollowUp);               // CSBuilder.cs:320
		public static TCoding Code_Mammogram6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Mammogram6MonthFollowUp);               // CSBuilder.cs:320
		public static TCoding Code_MammogramAndUltrasound3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MammogramAndUltrasound3MonthFollowUp);// CSBuilder.cs:320
		public static TCoding Code_MammogramAndUltrasound6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MammogramAndUltrasound6MonthFollowUp);// CSBuilder.cs:320
		public static TCoding Code_MediolateralObliqueView = new TCoding(RecommendationsCodeSystemCS.Code_MediolateralObliqueView);               // CSBuilder.cs:320
		public static TCoding Code_MediolateralView = new TCoding(RecommendationsCodeSystemCS.Code_MediolateralView);                             // CSBuilder.cs:320
		public static TCoding Code_MLOWithCompressionView = new TCoding(RecommendationsCodeSystemCS.Code_MLOWithCompressionView);                 // CSBuilder.cs:320
		public static TCoding Code_MLOWithMagnificationView = new TCoding(RecommendationsCodeSystemCS.Code_MLOWithMagnificationView);             // CSBuilder.cs:320
		public static TCoding Code_MRI = new TCoding(RecommendationsCodeSystemCS.Code_MRI);                                                       // CSBuilder.cs:320
		public static TCoding Code_MRIBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_MRIBiopsy);                                           // CSBuilder.cs:320
		public static TCoding Code_MRIFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_MRIFollowUp);                                       // CSBuilder.cs:320
		public static TCoding Code_NeedleLocationAndSurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_NeedleLocationAndSurgicalBiopsy);// CSBuilder.cs:320
		public static TCoding Code_NippleInProfileView = new TCoding(RecommendationsCodeSystemCS.Code_NippleInProfileView);                       // CSBuilder.cs:320
		public static TCoding Code_OffAngleCCView = new TCoding(RecommendationsCodeSystemCS.Code_OffAngleCCView);                                 // CSBuilder.cs:320
		public static TCoding Code_OffAngleMLOView = new TCoding(RecommendationsCodeSystemCS.Code_OffAngleMLOView);                               // CSBuilder.cs:320
		public static TCoding Code_PossStereotacticBx = new TCoding(RecommendationsCodeSystemCS.Code_PossStereotacticBx);                         // CSBuilder.cs:320
		public static TCoding Code_PossibleCoreBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleCoreBiopsy);                         // CSBuilder.cs:320
		public static TCoding Code_PossibleDiagnosticMammogram = new TCoding(RecommendationsCodeSystemCS.Code_PossibleDiagnosticMammogram);       // CSBuilder.cs:320
		public static TCoding Code_PossibleStereotacticVacuumBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleStereotacticVacuumBiopsy);// CSBuilder.cs:320
		public static TCoding Code_PossibleSurgicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_PossibleSurgicalConsult);               // CSBuilder.cs:320
		public static TCoding Code_PossibleSurgicalEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_PossibleSurgicalEvaluation);         // CSBuilder.cs:320
		public static TCoding Code_PossibleUltrasound = new TCoding(RecommendationsCodeSystemCS.Code_PossibleUltrasound);                         // CSBuilder.cs:320
		public static TCoding Code_PossibleUltrasoundGuidedBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleUltrasoundGuidedBiopsy); // CSBuilder.cs:320
		public static TCoding Code_PossibleVacuumBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_PossibleVacuumBiopsy);                     // CSBuilder.cs:320
		public static TCoding Code_RepeatCCView = new TCoding(RecommendationsCodeSystemCS.Code_RepeatCCView);                                     // CSBuilder.cs:320
		public static TCoding Code_RepeatMLOView = new TCoding(RecommendationsCodeSystemCS.Code_RepeatMLOView);                                   // CSBuilder.cs:320
		public static TCoding Code_RolledLateralView = new TCoding(RecommendationsCodeSystemCS.Code_RolledLateralView);                           // CSBuilder.cs:320
		public static TCoding Code_RolledMedialView = new TCoding(RecommendationsCodeSystemCS.Code_RolledMedialView);                             // CSBuilder.cs:320
		public static TCoding Code_ScintimammogramGuidedBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_ScintimammogramGuidedBiopsy);       // CSBuilder.cs:320
		public static TCoding Code_Scintimammography = new TCoding(RecommendationsCodeSystemCS.Code_Scintimammography);                           // CSBuilder.cs:320
		public static TCoding Code_SpotCompression = new TCoding(RecommendationsCodeSystemCS.Code_SpotCompression);                               // CSBuilder.cs:320
		public static TCoding Code_SpotMagnificationViews = new TCoding(RecommendationsCodeSystemCS.Code_SpotMagnificationViews);                 // CSBuilder.cs:320
		public static TCoding Code_StereotacticBx = new TCoding(RecommendationsCodeSystemCS.Code_StereotacticBx);                                 // CSBuilder.cs:320
		public static TCoding Code_SuperolateralIOView = new TCoding(RecommendationsCodeSystemCS.Code_SuperolateralIOView);                       // CSBuilder.cs:320
		public static TCoding Code_SurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalBiopsy);                                 // CSBuilder.cs:320
		public static TCoding Code_SurgicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalConsult);                               // CSBuilder.cs:320
		public static TCoding Code_SurgicalConsultAndBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalConsultAndBiopsy);             // CSBuilder.cs:320
		public static TCoding Code_SurgicalEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalEvaluation);                         // CSBuilder.cs:320
		public static TCoding Code_SurgicalExcision = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalExcision);                             // CSBuilder.cs:320
		public static TCoding Code_SurgicalOncologicEvaluation = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalOncologicEvaluation);       // CSBuilder.cs:320
		public static TCoding Code_SurgicalOncologicalConsult = new TCoding(RecommendationsCodeSystemCS.Code_SurgicalOncologicalConsult);         // CSBuilder.cs:320
		public static TCoding Code_TangentialView = new TCoding(RecommendationsCodeSystemCS.Code_TangentialView);                                 // CSBuilder.cs:320
		public static TCoding Code_TangentialViews = new TCoding(RecommendationsCodeSystemCS.Code_TangentialViews);                               // CSBuilder.cs:320
		public static TCoding Code_Ultrasound = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound);                                         // CSBuilder.cs:320
		public static TCoding Code_Ultrasound2ndLook = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound2ndLook);                           // CSBuilder.cs:320
		public static TCoding Code_Ultrasound3MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound3MonthFollowUp);             // CSBuilder.cs:320
		public static TCoding Code_Ultrasound6MonthFollowUp = new TCoding(RecommendationsCodeSystemCS.Code_Ultrasound6MonthFollowUp);             // CSBuilder.cs:320
		public static TCoding Code_UltrasoundGuidedBx = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundGuidedBx);                         // CSBuilder.cs:320
		public static TCoding Code_UltrasoundLocationAndSurgicalBiopsy = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundLocationAndSurgicalBiopsy);// CSBuilder.cs:320
		public static TCoding Code_UltrasoundWithPossibleAddlitonalViews = new TCoding(RecommendationsCodeSystemCS.Code_UltrasoundWithPossibleAddlitonalViews);// CSBuilder.cs:320
		public static TCoding Code_UnspecifiedOther = new TCoding(RecommendationsCodeSystemCS.Code_UnspecifiedOther);                             // CSBuilder.cs:320
		public static TCoding Code_VacuumBx = new TCoding(RecommendationsCodeSystemCS.Code_VacuumBx);                                             // CSBuilder.cs:320
		//- Fields

		//+ Methods
		public static IEnumerable<TCoding> Codes()                                                                                                // CSBuilder.cs:305
		{                                                                                                                                         // CSBuilder.cs:306
		    yield return Code_3DImaging;                                                                                                          // CSBuilder.cs:323
		    yield return Code_3DSpotCC;                                                                                                           // CSBuilder.cs:323
		    yield return Code_3DSpotLM;                                                                                                           // CSBuilder.cs:323
		    yield return Code_3DSpotML;                                                                                                           // CSBuilder.cs:323
		    yield return Code_3DSpotMLO;                                                                                                          // CSBuilder.cs:323
		    yield return Code_AdditionalViews;                                                                                                    // CSBuilder.cs:323
		    yield return Code_AddlitionalViewsWithPossibleUltrasound;                                                                             // CSBuilder.cs:323
		    yield return Code_AxillaView;                                                                                                         // CSBuilder.cs:323
		    yield return Code_AxillaryTailView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_Biopsy;                                                                                                             // CSBuilder.cs:323
		    yield return Code_BiopsyBaseOnClinical;                                                                                               // CSBuilder.cs:323
		    yield return Code_CaudocranialView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_CCWithCompressionView;                                                                                              // CSBuilder.cs:323
		    yield return Code_CCWithMagnificationView;                                                                                            // CSBuilder.cs:323
		    yield return Code_CleavageView;                                                                                                       // CSBuilder.cs:323
		    yield return Code_ClinicalConsultation;                                                                                               // CSBuilder.cs:323
		    yield return Code_ClinicalCorrelation;                                                                                                // CSBuilder.cs:323
		    yield return Code_ClinicalFollowUp;                                                                                                   // CSBuilder.cs:323
		    yield return Code_CompareToPriorExams;                                                                                                // CSBuilder.cs:323
		    yield return Code_CompressionViews;                                                                                                   // CSBuilder.cs:323
		    yield return Code_ConeCompression;                                                                                                    // CSBuilder.cs:323
		    yield return Code_CoreBiopsy;                                                                                                         // CSBuilder.cs:323
		    yield return Code_CraniocaudalView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_Cryoablation;                                                                                                       // CSBuilder.cs:323
		    yield return Code_CystAspiration;                                                                                                     // CSBuilder.cs:323
		    yield return Code_CystAspirationForRelief;                                                                                            // CSBuilder.cs:323
		    yield return Code_DiagnosticAspiration;                                                                                               // CSBuilder.cs:323
		    yield return Code_DiagnosticMammogram;                                                                                                // CSBuilder.cs:323
		    yield return Code_DrainageTube;                                                                                                       // CSBuilder.cs:323
		    yield return Code_Ductography;                                                                                                        // CSBuilder.cs:323
		    yield return Code_ExaggeratedCCViews;                                                                                                 // CSBuilder.cs:323
		    yield return Code_FNABiopsy;                                                                                                          // CSBuilder.cs:323
		    yield return Code_FollowUp;                                                                                                           // CSBuilder.cs:323
		    yield return Code_Followup3Months;                                                                                                    // CSBuilder.cs:323
		    yield return Code_Followup6Months;                                                                                                    // CSBuilder.cs:323
		    yield return Code_IfPreviousShowNoChange;                                                                                             // CSBuilder.cs:323
		    yield return Code_LateralMagnificationView;                                                                                           // CSBuilder.cs:323
		    yield return Code_LateralMedialView;                                                                                                  // CSBuilder.cs:323
		    yield return Code_LateralView;                                                                                                        // CSBuilder.cs:323
		    yield return Code_LateralWithCompressionView;                                                                                         // CSBuilder.cs:323
		    yield return Code_LateromedialOblique;                                                                                                // CSBuilder.cs:323
		    yield return Code_LateromedialView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_LymphNodeAssessment;                                                                                                // CSBuilder.cs:323
		    yield return Code_MagnificationViews;                                                                                                 // CSBuilder.cs:323
		    yield return Code_Mammogram;                                                                                                          // CSBuilder.cs:323
		    yield return Code_Mammogram3MonthFollowUp;                                                                                            // CSBuilder.cs:323
		    yield return Code_Mammogram6MonthFollowUp;                                                                                            // CSBuilder.cs:323
		    yield return Code_MammogramAndUltrasound3MonthFollowUp;                                                                               // CSBuilder.cs:323
		    yield return Code_MammogramAndUltrasound6MonthFollowUp;                                                                               // CSBuilder.cs:323
		    yield return Code_MediolateralObliqueView;                                                                                            // CSBuilder.cs:323
		    yield return Code_MediolateralView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_MLOWithCompressionView;                                                                                             // CSBuilder.cs:323
		    yield return Code_MLOWithMagnificationView;                                                                                           // CSBuilder.cs:323
		    yield return Code_MRI;                                                                                                                // CSBuilder.cs:323
		    yield return Code_MRIBiopsy;                                                                                                          // CSBuilder.cs:323
		    yield return Code_MRIFollowUp;                                                                                                        // CSBuilder.cs:323
		    yield return Code_NeedleLocationAndSurgicalBiopsy;                                                                                    // CSBuilder.cs:323
		    yield return Code_NippleInProfileView;                                                                                                // CSBuilder.cs:323
		    yield return Code_OffAngleCCView;                                                                                                     // CSBuilder.cs:323
		    yield return Code_OffAngleMLOView;                                                                                                    // CSBuilder.cs:323
		    yield return Code_PossStereotacticBx;                                                                                                 // CSBuilder.cs:323
		    yield return Code_PossibleCoreBiopsy;                                                                                                 // CSBuilder.cs:323
		    yield return Code_PossibleDiagnosticMammogram;                                                                                        // CSBuilder.cs:323
		    yield return Code_PossibleStereotacticVacuumBiopsy;                                                                                   // CSBuilder.cs:323
		    yield return Code_PossibleSurgicalConsult;                                                                                            // CSBuilder.cs:323
		    yield return Code_PossibleSurgicalEvaluation;                                                                                         // CSBuilder.cs:323
		    yield return Code_PossibleUltrasound;                                                                                                 // CSBuilder.cs:323
		    yield return Code_PossibleUltrasoundGuidedBiopsy;                                                                                     // CSBuilder.cs:323
		    yield return Code_PossibleVacuumBiopsy;                                                                                               // CSBuilder.cs:323
		    yield return Code_RepeatCCView;                                                                                                       // CSBuilder.cs:323
		    yield return Code_RepeatMLOView;                                                                                                      // CSBuilder.cs:323
		    yield return Code_RolledLateralView;                                                                                                  // CSBuilder.cs:323
		    yield return Code_RolledMedialView;                                                                                                   // CSBuilder.cs:323
		    yield return Code_ScintimammogramGuidedBiopsy;                                                                                        // CSBuilder.cs:323
		    yield return Code_Scintimammography;                                                                                                  // CSBuilder.cs:323
		    yield return Code_SpotCompression;                                                                                                    // CSBuilder.cs:323
		    yield return Code_SpotMagnificationViews;                                                                                             // CSBuilder.cs:323
		    yield return Code_StereotacticBx;                                                                                                     // CSBuilder.cs:323
		    yield return Code_SuperolateralIOView;                                                                                                // CSBuilder.cs:323
		    yield return Code_SurgicalBiopsy;                                                                                                     // CSBuilder.cs:323
		    yield return Code_SurgicalConsult;                                                                                                    // CSBuilder.cs:323
		    yield return Code_SurgicalConsultAndBiopsy;                                                                                           // CSBuilder.cs:323
		    yield return Code_SurgicalEvaluation;                                                                                                 // CSBuilder.cs:323
		    yield return Code_SurgicalExcision;                                                                                                   // CSBuilder.cs:323
		    yield return Code_SurgicalOncologicEvaluation;                                                                                        // CSBuilder.cs:323
		    yield return Code_SurgicalOncologicalConsult;                                                                                         // CSBuilder.cs:323
		    yield return Code_TangentialView;                                                                                                     // CSBuilder.cs:323
		    yield return Code_TangentialViews;                                                                                                    // CSBuilder.cs:323
		    yield return Code_Ultrasound;                                                                                                         // CSBuilder.cs:323
		    yield return Code_Ultrasound2ndLook;                                                                                                  // CSBuilder.cs:323
		    yield return Code_Ultrasound3MonthFollowUp;                                                                                           // CSBuilder.cs:323
		    yield return Code_Ultrasound6MonthFollowUp;                                                                                           // CSBuilder.cs:323
		    yield return Code_UltrasoundGuidedBx;                                                                                                 // CSBuilder.cs:323
		    yield return Code_UltrasoundLocationAndSurgicalBiopsy;                                                                                // CSBuilder.cs:323
		    yield return Code_UltrasoundWithPossibleAddlitonalViews;                                                                              // CSBuilder.cs:323
		    yield return Code_UnspecifiedOther;                                                                                                   // CSBuilder.cs:323
		    yield return Code_VacuumBx;                                                                                                           // CSBuilder.cs:323
		}                                                                                                                                         // CSBuilder.cs:329
		//- Methods
	}
}
