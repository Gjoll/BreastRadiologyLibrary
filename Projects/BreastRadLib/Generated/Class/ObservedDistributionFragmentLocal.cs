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
	public class ObsDistribution_Accessor : MemberListCodedValueBase<CodeableConcept>                                                          // BuildMemberListCodedValue.cs:64
	{                                                                                                                                          // BuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListCodedValue.cs:134
	                                                                                                                                           // BuildMemberListCodedValue.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListCodedValue.cs:140
	                                                                                                                                           // BuildMemberListCodedValue.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListCodedValue.cs:146
	                                                                                                                                           // BuildMemberListCodedValue.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListCodedValue.cs:151
	                                                                                                                                           // BuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:69
	                                                                                                                                           // BuildMemberListCodedValue.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(CalcificationDistributionVS.TCoding value)                                                                          // BuildMemberListCodedValue.cs:122
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:123
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:124
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:125
	                                                                                                                                           // BuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistribution_Accessor(BreastRadiologyDocument doc) : base("ObsDistribution_Accessor")                                        // BuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, -1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsDistribution"));// BuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:79
	}                                                                                                                                          // BuildMemberListCodedValue.cs:80
	/// <summary>
	/// Accessor class for 'obsDistRegionSize'
	/// [Fhir Element 'Observation.component:obsDistRegionSize]'
	/// </summary>
	public class ObsDistRegionSize_Accessor : MemberListCodedValueBase<Element>                                                                // BuildMemberListCodedValue.cs:64
	{                                                                                                                                          // BuildMemberListCodedValue.cs:65
	    // Properties                                                                                                                          // BuildMemberListCodedValue.cs:66
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<Element> All() => this.items;                                                                                       // BuildMemberListCodedValue.cs:134
	                                                                                                                                           // BuildMemberListCodedValue.cs:136
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public Element At(Int32 i) => base.items[i];                                                                                           // BuildMemberListCodedValue.cs:140
	                                                                                                                                           // BuildMemberListCodedValue.cs:142
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new Element First() => base.First();                                                                                            // BuildMemberListCodedValue.cs:146
	                                                                                                                                           // BuildMemberListCodedValue.cs:147
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new Element FirstOrDefault() => base.FirstOrDefault();                                                                          // BuildMemberListCodedValue.cs:151
	                                                                                                                                           // BuildMemberListCodedValue.cs:68
	    // Methods                                                                                                                             // BuildMemberListCodedValue.cs:69
	                                                                                                                                           // BuildMemberListCodedValue.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendQuantity(Quantity value)                                                                                             // BuildMemberListCodedValue.cs:122
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:123
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:124
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:125
	                                                                                                                                           // BuildMemberListCodedValue.cs:118
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendRange(Quantity value)                                                                                                // BuildMemberListCodedValue.cs:122
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:123
	        this.RawItems.Add(value);                                                                                                          // BuildMemberListCodedValue.cs:124
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:125
	                                                                                                                                           // BuildMemberListCodedValue.cs:71
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public ObsDistRegionSize_Accessor(BreastRadiologyDocument doc) : base("ObsDistRegionSize_Accessor")                                    // BuildMemberListCodedValue.cs:75
	    {                                                                                                                                      // BuildMemberListCodedValue.cs:76
	        this.Init(doc, 0, 3, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "obsSize"));  // BuildMemberListCodedValue.cs:77
	    }                                                                                                                                      // BuildMemberListCodedValue.cs:79
	}                                                                                                                                          // BuildMemberListCodedValue.cs:80
	//- LocalClassDefs
}
