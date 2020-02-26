using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public static class ResourceFactory
    {
        public static BaseBase CreateBreastRadProfileResource(BreastRadiologyDocument doc,
            String profile,
            Base resource)
        {
            switch (profile.ToLower().Trim())
            {
                //+ Profile
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/servicerecommendation":                                   // Builder.cs:139
                    return new ServiceRecommendation(doc, (ServiceRequest) resource);                                                       // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/bodydistancefromextension":                               // Builder.cs:139
                    return new BodyDistanceFromExtension(doc, (Extension) resource);                                                        // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastbodylocationextension":                             // Builder.cs:139
                    return new BreastBodyLocationExtension(doc, (Extension) resource);                                                      // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradcomposition":                                    // Builder.cs:139
                    return new BreastRadComposition(doc, (Composition) resource);                                                           // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradreport":                                         // Builder.cs:139
                    return new BreastRadReport(doc, (DiagnosticReport) resource);                                                           // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/consistentwith":                                          // Builder.cs:139
                    return new ConsistentWith(doc, (Observation) resource);                                                                 // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgbreastdensity":                                         // Builder.cs:139
                    return new MGBreastDensity(doc, (Observation) resource);                                                                // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedfeature":                                         // Builder.cs:139
                    return new ObservedFeature(doc, (Observation) resource);                                                                // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsleftbreast":                               // Builder.cs:139
                    return new SectionFindingsLeftBreast(doc, (Observation) resource);                                                      // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsrightbreast":                              // Builder.cs:139
                    return new SectionFindingsRightBreast(doc, (Observation) resource);                                                     // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/tumorsatellite":                                          // Builder.cs:139
                    return new TumorSatellite(doc, (Observation) resource);                                                                 // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/usfinding":                                               // Builder.cs:139
                    return new USFinding(doc, (Observation) resource);                                                                      // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitycyst":                                         // Builder.cs:139
                    return new AbnormalityCyst(doc, (Observation) resource);                                                                // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityduct":                                         // Builder.cs:139
                    return new AbnormalityDuct(doc, (Observation) resource);                                                                // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityfibroadenoma":                                 // Builder.cs:139
                    return new AbnormalityFibroadenoma(doc, (Observation) resource);                                                        // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityforeignobject":                                // Builder.cs:139
                    return new AbnormalityForeignObject(doc, (Observation) resource);                                                       // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitylymphnode":                                    // Builder.cs:139
                    return new AbnormalityLymphNode(doc, (Observation) resource);                                                           // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitymass":                                         // Builder.cs:139
                    return new AbnormalityMass(doc, (Observation) resource);                                                                // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/associatedfeatures":                                      // Builder.cs:139
                    return new AssociatedFeatures(doc, (Observation) resource);                                                             // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityarchitecturaldistortion":                    // Builder.cs:139
                    return new MGAbnormalityArchitecturalDistortion(doc, (Observation) resource);                                           // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityasymmetry":                                  // Builder.cs:139
                    return new MGAbnormalityAsymmetry(doc, (Observation) resource);                                                         // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitycalcification":                              // Builder.cs:139
                    return new MGAbnormalityCalcification(doc, (Observation) resource);                                                     // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitydensity":                                    // Builder.cs:139
                    return new MGAbnormalityDensity(doc, (Observation) resource);                                                           // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityfatnecrosis":                                // Builder.cs:139
                    return new MGAbnormalityFatNecrosis(doc, (Observation) resource);                                                       // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgfinding":                                               // Builder.cs:139
                    return new MGFinding(doc, (Observation) resource);                                                                      // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mrifinding":                                              // Builder.cs:139
                    return new MRIFinding(doc, (Observation) resource);                                                                     // Builder.cs:140
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/nmfinding":                                               // Builder.cs:139
                    return new NMFinding(doc, (Observation) resource);                                                                      // Builder.cs:140
                                                                                                                                            //- Profile
            }
            return null;
        }
    }
}
