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
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/usfinding":                                               // CSBuilder.cs:141
                    return new USFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/tumorsatellitefragment":                                  // CSBuilder.cs:141
                    return new TumorSatelliteFragment(doc, (Observation) resource);                                                         // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/tumorsatellite":                                          // CSBuilder.cs:141
                    return new TumorSatellite(doc, (Observation) resource);                                                                 // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/shapecomponentsfragment":                                 // CSBuilder.cs:141
                    return new ShapeComponentsFragment(doc, (Observation) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/servicerecommendation":                                   // CSBuilder.cs:141
                    return new ServiceRecommendation(doc, (ServiceRequest) resource);                                                       // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsrightbreast":                              // CSBuilder.cs:141
                    return new SectionFindingsRightBreast(doc, (Observation) resource);                                                     // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/sectionfindingsleftbreast":                               // CSBuilder.cs:141
                    return new SectionFindingsLeftBreast(doc, (Observation) resource);                                                      // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/previouslydemonstratedbyfragment":                        // CSBuilder.cs:141
                    return new PreviouslyDemonstratedByFragment(doc, (Observation) resource);                                               // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedsizefragment":                                    // CSBuilder.cs:141
                    return new ObservedSizeFragment(doc, (Observation) resource);                                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedfeature":                                         // CSBuilder.cs:141
                    return new ObservedFeature(doc, (Observation) resource);                                                                // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observeddistributionfragment":                            // CSBuilder.cs:141
                    return new ObservedDistributionFragment(doc, (Observation) resource);                                                   // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedcountfragment":                                   // CSBuilder.cs:141
                    return new ObservedCountFragment(doc, (Observation) resource);                                                          // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observedchangesfragment":                                 // CSBuilder.cs:141
                    return new ObservedChangesFragment(doc, (Observation) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observationsectionfragment":                              // CSBuilder.cs:141
                    return new ObservationSectionFragment(doc, (Observation) resource);                                                     // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/observationleaffragment":                                 // CSBuilder.cs:141
                    return new ObservationLeafFragment(doc, (Observation) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/notpreviouslyseencomponentfragment":                      // CSBuilder.cs:141
                    return new NotPreviouslySeenComponentFragment(doc, (Observation) resource);                                             // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/nmfinding":                                               // CSBuilder.cs:141
                    return new NMFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mrifinding":                                              // CSBuilder.cs:141
                    return new MRIFinding(doc, (Observation) resource);                                                                     // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgfinding":                                               // CSBuilder.cs:141
                    return new MGFinding(doc, (Observation) resource);                                                                      // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgbreastdensity":                                         // CSBuilder.cs:141
                    return new MGBreastDensity(doc, (Observation) resource);                                                                // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityfatnecrosis":                                // CSBuilder.cs:141
                    return new MGAbnormalityFatNecrosis(doc, (Observation) resource);                                                       // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitydensity":                                    // CSBuilder.cs:141
                    return new MGAbnormalityDensity(doc, (Observation) resource);                                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalitycalcification":                              // CSBuilder.cs:141
                    return new MGAbnormalityCalcification(doc, (Observation) resource);                                                     // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityasymmetry":                                  // CSBuilder.cs:141
                    return new MGAbnormalityAsymmetry(doc, (Observation) resource);                                                         // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/mgabnormalityarchitecturaldistortion":                    // CSBuilder.cs:141
                    return new MGAbnormalityArchitecturalDistortion(doc, (Observation) resource);                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/headerfragment":                                          // CSBuilder.cs:141
                    return new HeaderFragment(doc, (Resource) resource);                                                                    // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/findingbreastfragment":                                   // CSBuilder.cs:141
                    return new FindingBreastFragment(doc, (Observation) resource);                                                          // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/correspondswithfragment":                                 // CSBuilder.cs:141
                    return new CorrespondsWithFragment(doc, (Observation) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/consistentwithhasmemberfragment":                         // CSBuilder.cs:141
                    return new ConsistentWithHasMemberFragment(doc, (Observation) resource);                                                // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/consistentwith":                                          // CSBuilder.cs:141
                    return new ConsistentWith(doc, (Observation) resource);                                                                 // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/commoncomponentsfragment":                                // CSBuilder.cs:141
                    return new CommonComponentsFragment(doc, (Observation) resource);                                                       // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/categoryfragment":                                        // CSBuilder.cs:141
                    return new CategoryFragment(doc, (Observation) resource);                                                               // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradreport":                                         // CSBuilder.cs:141
                    return new BreastRadReport(doc, (DiagnosticReport) resource);                                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradobservationnovaluefragment":                     // CSBuilder.cs:141
                    return new BreastRadObservationNoValueFragment(doc, (Observation) resource);                                            // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradobservationnodevicefragment":                    // CSBuilder.cs:141
                    return new BreastRadObservationNoDeviceFragment(doc, (Observation) resource);                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradobservationnocomponentfragment":                 // CSBuilder.cs:141
                    return new BreastRadObservationNoComponentFragment(doc, (Observation) resource);                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradobservationfragment":                            // CSBuilder.cs:141
                    return new BreastRadObservationFragment(doc, (Observation) resource);                                                   // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastradcomposition":                                    // CSBuilder.cs:141
                    return new BreastRadComposition(doc, (Composition) resource);                                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastbodylocationrequiredfragment":                      // CSBuilder.cs:141
                    return new BreastBodyLocationRequiredFragment(doc, (Observation) resource);                                             // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/breastbodylocationextension":                             // CSBuilder.cs:141
                    return new BreastBodyLocationExtension(doc, (Extension) resource);                                                      // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/bodydistancefromextension":                               // CSBuilder.cs:141
                    return new BodyDistanceFromExtension(doc, (Extension) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/biradfragment":                                           // CSBuilder.cs:141
                    return new BiRadFragment(doc, (Observation) resource);                                                                  // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/associatedfeatureshasmemberfragment":                     // CSBuilder.cs:141
                    return new AssociatedFeaturesHasMemberFragment(doc, (Observation) resource);                                            // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/associatedfeatures":                                      // CSBuilder.cs:141
                    return new AssociatedFeatures(doc, (Observation) resource);                                                             // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitymass":                                         // CSBuilder.cs:141
                    return new AbnormalityMass(doc, (Observation) resource);                                                                // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitylymphnode":                                    // CSBuilder.cs:141
                    return new AbnormalityLymphNode(doc, (Observation) resource);                                                           // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityforeignobject":                                // CSBuilder.cs:141
                    return new AbnormalityForeignObject(doc, (Observation) resource);                                                       // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityfibroadenoma":                                 // CSBuilder.cs:141
                    return new AbnormalityFibroadenoma(doc, (Observation) resource);                                                        // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalityduct":                                         // CSBuilder.cs:141
                    return new AbnormalityDuct(doc, (Observation) resource);                                                                // CSBuilder.cs:142
                case "http://hl7.org/fhir/us/breast-radiology/structuredefinition/abnormalitycyst":                                         // CSBuilder.cs:141
                    return new AbnormalityCyst(doc, (Observation) resource);                                                                // CSBuilder.cs:142
                                                                                                                                            //- Profile
            }
            return null;
        }
    }
}
