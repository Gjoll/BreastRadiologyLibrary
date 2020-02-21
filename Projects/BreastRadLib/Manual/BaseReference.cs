﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public class BaseReference<T>
        where T : BaseBase, new()
    {
        BreastRadiologyDocument doc;
        T value;

        public T Get() => this.value;
        public T Create()
        {
            T value = new T();
            value.Init(this.doc);
            return this.Create(value);
        }

        public T Create(T value)
        {
            if (this.value != null)
                throw new Exception($"Can not modify value after it has been set.");
            this.value = value;
            this.doc.Register(value);
            return value;
        }

        public BaseReference(BreastRadiologyDocument doc)
        {
            this.doc = doc;
        }

    }
}
