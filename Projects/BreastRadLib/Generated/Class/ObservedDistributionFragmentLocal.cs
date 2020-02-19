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
	public class ObsDistribution_Accessor : MemberListCodedValueBase<CodeableConcept>                                                          // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // CSBuildMemberListCodedValue.cs:139
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // CSBuildMemberListCodedValue.cs:145
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // CSBuildMemberListCodedValue.cs:151
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // CSBuildMemberListCodedValue.cs:156
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:123
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CalcificationDistributionVS.TCoding value)                                                                          // CSBuildMemberListCodedValue.cs:127
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:128
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:129
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:130
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistribution_Accessor(BreastRadiologyDocument doc) : base("ObsDistribution_Accessor")                                        // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsDistribution"));// CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	/// <summary>
	/// Accessor class for 'obsDistRegionSize'
	/// [Fhir Element 'Observation.component:obsDistRegionSize]'
	/// </summary>
	public class ObsDistRegionSize_Accessor : MemberListCodedValueBase<Element>                                                                // CSBuildMemberListCodedValue.cs:69
	{                                                                                                                                          // CSBuildMemberListCodedValue.cs:70
	    // Properties                                                                                                                          // CSBuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // CSBuildMemberListCodedValue.cs:139
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:141
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // CSBuildMemberListCodedValue.cs:145
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:147
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // CSBuildMemberListCodedValue.cs:151
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:152
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // CSBuildMemberListCodedValue.cs:156
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:73
	    // Methods                                                                                                                             // CSBuildMemberListCodedValue.cs:74
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:123
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // CSBuildMemberListCodedValue.cs:127
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:128
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:129
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:130
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:123
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // CSBuildMemberListCodedValue.cs:127
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:128
	        this.RawItems.Add(value);                                                                                                          // CSBuildMemberListCodedValue.cs:129
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:130
	                                                                                                                                           // CSBuildMemberListCodedValue.cs:76
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistRegionSize_Accessor(BreastRadiologyDocument doc) : base("ObsDistRegionSize_Accessor")                                    // CSBuildMemberListCodedValue.cs:80
	    {                                                                                                                                      // CSBuildMemberListCodedValue.cs:81
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // CSBuildMemberListCodedValue.cs:82
	    }                                                                                                                                      // CSBuildMemberListCodedValue.cs:84
	}                                                                                                                                          // CSBuildMemberListCodedValue.cs:85
	//- LocalClassDefs
}
