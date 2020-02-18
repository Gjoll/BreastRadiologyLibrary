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
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/servicerecommendation":                                   // CSBuilder.cs:144
                    return new ServiceRecommendation(doc, (ServiceRequest) resource);                                                       // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/bodydistancefromextension":                               // CSBuilder.cs:144
                    return new BodyDistanceFromExtension(doc, (Extension) resource);                                                        // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastbodylocationextension":                             // CSBuilder.cs:144
                    return new BreastBodyLocationExtension(doc, (Extension) resource);                                                      // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradcomposition":                                    // CSBuilder.cs:144
                    return new BreastRadComposition(doc, (Composition) resource);                                                           // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradreport":                                         // CSBuilder.cs:144
                    return new BreastRadReport(doc, (DiagnosticReport) resource);                                                           // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/consistentwith":                                          // CSBuilder.cs:144
                    return new ConsistentWith(doc, (Observation) resource);                                                                 // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgbreastdensity":                                         // CSBuilder.cs:144
                    return new MGBreastDensity(doc, (Observation) resource);                                                                // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedfeature":                                         // CSBuilder.cs:144
                    return new ObservedFeature(doc, (Observation) resource);                                                                // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsleftbreast":                               // CSBuilder.cs:144
                    return new SectionFindingsLeftBreast(doc, (Observation) resource);                                                      // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsrightbreast":                              // CSBuilder.cs:144
                    return new SectionFindingsRightBreast(doc, (Observation) resource);                                                     // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/tumorsatellite":                                          // CSBuilder.cs:144
                    return new TumorSatellite(doc, (Observation) resource);                                                                 // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/usfinding":                                               // CSBuilder.cs:144
                    return new USFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitycyst":                                         // CSBuilder.cs:144
                    return new AbnormalityCyst(doc, (Observation) resource);                                                                // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityduct":                                         // CSBuilder.cs:144
                    return new AbnormalityDuct(doc, (Observation) resource);                                                                // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityfibroadenoma":                                 // CSBuilder.cs:144
                    return new AbnormalityFibroadenoma(doc, (Observation) resource);                                                        // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityforeignobject":                                // CSBuilder.cs:144
                    return new AbnormalityForeignObject(doc, (Observation) resource);                                                       // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitylymphnode":                                    // CSBuilder.cs:144
                    return new AbnormalityLymphNode(doc, (Observation) resource);                                                           // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitymass":                                         // CSBuilder.cs:144
                    return new AbnormalityMass(doc, (Observation) resource);                                                                // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/associatedfeatures":                                      // CSBuilder.cs:144
                    return new AssociatedFeatures(doc, (Observation) resource);                                                             // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityarchitecturaldistortion":                    // CSBuilder.cs:144
                    return new MGAbnormalityArchitecturalDistortion(doc, (Observation) resource);                                           // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityasymmetry":                                  // CSBuilder.cs:144
                    return new MGAbnormalityAsymmetry(doc, (Observation) resource);                                                         // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitycalcification":                              // CSBuilder.cs:144
                    return new MGAbnormalityCalcification(doc, (Observation) resource);                                                     // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitydensity":                                    // CSBuilder.cs:144
                    return new MGAbnormalityDensity(doc, (Observation) resource);                                                           // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityfatnecrosis":                                // CSBuilder.cs:144
                    return new MGAbnormalityFatNecrosis(doc, (Observation) resource);                                                       // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgfinding":                                               // CSBuilder.cs:144
                    return new MGFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mrifinding":                                              // CSBuilder.cs:144
                    return new MRIFinding(doc, (Observation) resource);                                                                     // CSBuilder.cs:145
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/nmfinding":                                               // CSBuilder.cs:144
                    return new NMFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:145
                                                                                                                                            //- Profile
            }
            return null;
        }
    }
}
