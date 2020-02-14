using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class ResourceFactory
    {
        public static BaseBase CreateBreastRadProfileResource(BreastRadiologyDocument doc, String profile)
        {
            switch (profile.ToLower().Trim())
            {
                //+ Profile
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/usfinding":                                               // CSBuilder.cs:150
                    return new USFinding(doc);                                                                                              // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/tumorsatellite":                                          // CSBuilder.cs:150
                    return new TumorSatellite(doc);                                                                                         // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/servicerecommendation":                                   // CSBuilder.cs:150
                    return new ServiceRecommendation(doc);                                                                                  // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsrightbreast":                              // CSBuilder.cs:150
                    return new SectionFindingsRightBreast(doc);                                                                             // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsleftbreast":                               // CSBuilder.cs:150
                    return new SectionFindingsLeftBreast(doc);                                                                              // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedfeature":                                         // CSBuilder.cs:150
                    return new ObservedFeature(doc);                                                                                        // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/nmfinding":                                               // CSBuilder.cs:150
                    return new NMFinding(doc);                                                                                              // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mrifinding":                                              // CSBuilder.cs:150
                    return new MRIFinding(doc);                                                                                             // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgfinding":                                               // CSBuilder.cs:150
                    return new MGFinding(doc);                                                                                              // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgbreastdensity":                                         // CSBuilder.cs:150
                    return new MGBreastDensity(doc);                                                                                        // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityfatnecrosis":                                // CSBuilder.cs:150
                    return new MGAbnormalityFatNecrosis(doc);                                                                               // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitydensity":                                    // CSBuilder.cs:150
                    return new MGAbnormalityDensity(doc);                                                                                   // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitycalcification":                              // CSBuilder.cs:150
                    return new MGAbnormalityCalcification(doc);                                                                             // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityasymmetry":                                  // CSBuilder.cs:150
                    return new MGAbnormalityAsymmetry(doc);                                                                                 // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityarchitecturaldistortion":                    // CSBuilder.cs:150
                    return new MGAbnormalityArchitecturalDistortion(doc);                                                                   // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/consistentwith":                                          // CSBuilder.cs:150
                    return new ConsistentWith(doc);                                                                                         // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradreport":                                         // CSBuilder.cs:150
                    return new BreastRadReport(doc);                                                                                        // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradcomposition":                                    // CSBuilder.cs:150
                    return new BreastRadComposition(doc);                                                                                   // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastbodylocationextension":                             // CSBuilder.cs:150
                    return new BreastBodyLocationExtension(doc);                                                                            // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/bodydistancefromextension":                               // CSBuilder.cs:150
                    return new BodyDistanceFromExtension(doc);                                                                              // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/associatedfeatures":                                      // CSBuilder.cs:150
                    return new AssociatedFeatures(doc);                                                                                     // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitymass":                                         // CSBuilder.cs:150
                    return new AbnormalityMass(doc);                                                                                        // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitylymphnode":                                    // CSBuilder.cs:150
                    return new AbnormalityLymphNode(doc);                                                                                   // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityforeignobject":                                // CSBuilder.cs:150
                    return new AbnormalityForeignObject(doc);                                                                               // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityfibroadenoma":                                 // CSBuilder.cs:150
                    return new AbnormalityFibroadenoma(doc);                                                                                // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityduct":                                         // CSBuilder.cs:150
                    return new AbnormalityDuct(doc);                                                                                        // CSBuilder.cs:151
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitycyst":                                         // CSBuilder.cs:150
                    return new AbnormalityCyst(doc);                                                                                        // CSBuilder.cs:151
                                                                                                                                            //- Profile
            }
            return null;
        }
    }
}
