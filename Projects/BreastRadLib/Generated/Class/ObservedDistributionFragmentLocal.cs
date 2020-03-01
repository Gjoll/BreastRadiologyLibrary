using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ObservedDistributionFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for 'obsDistribution'
	/// [Fhir Element 'Observation.component:obsDistribution]'
	/// </summary>
	public class ObsDistribution_Accessor : MemberListCodedValue<CodeableConcept>                                                              // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListCodedValue.cs:142
	                                                                                                                                           // BuildMemberListCodedValue.cs:144
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListCodedValue.cs:148
	                                                                                                                                           // BuildMemberListCodedValue.cs:150
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListCodedValue.cs:154
	                                                                                                                                           // BuildMemberListCodedValue.cs:155
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListCodedValue.cs:159
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CalcificationDistributionVS.TCoding value)                                                                          // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistribution_Accessor(BreastRadiologyDocument doc) : base("ObsDistribution_Accessor")                                        // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsDistribution"));// BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	/// <summary>
	/// Accessor class for 'obsDistRegionSize'
	/// [Fhir Element 'Observation.component:obsDistRegionSize]'
	/// </summary>
	public class ObsDistRegionSize_Accessor : MemberListCodedValue<Element>                                                                    // BuildMemberListCodedValue.cs:72
	{                                                                                                                                          // BuildMemberListCodedValue.cs:73
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:74
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // BuildMemberListCodedValue.cs:142
	                                                                                                                                           // BuildMemberListCodedValue.cs:144
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // BuildMemberListCodedValue.cs:148
	                                                                                                                                           // BuildMemberListCodedValue.cs:150
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // BuildMemberListCodedValue.cs:154
	                                                                                                                                           // BuildMemberListCodedValue.cs:155
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // BuildMemberListCodedValue.cs:159
	                                                                                                                                           // BuildMemberListCodedValue.cs:76
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:77
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:126
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // BuildMemberListCodedValue.cs:130
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:131
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:132
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:133
	                                                                                                                                           // BuildMemberListCodedValue.cs:79
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistRegionSize_Accessor(BreastRadiologyDocument doc) : base("ObsDistRegionSize_Accessor")                                    // BuildMemberListCodedValue.cs:83
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:84
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // BuildMemberListCodedValue.cs:85
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:87
	}                                                                                                                                          // BuildMemberListCodedValue.cs:88
	//- LocalClassDefs
}
