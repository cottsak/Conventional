﻿using System;
using Conventional.Cecil.Conventions;

namespace Conventional.Cecil
{
    public static class CecilConvention
    {
        public static MustNotUseDateTimeNowConventionSpecification MustNotUseDateTimeNow
        {
            get { return new MustNotUseDateTimeNowConventionSpecification(); }
        }
        
        public static MustNotUseDateTimeOffsetNowConventionSpecification MustNotUseDateTimeOffsetNow
        {
            get { return new MustNotUseDateTimeOffsetNowConventionSpecification(); }
        }

        public static ExceptionsThrownMustBeDerivedFromConventionSpecification ExceptionsThrownMustBeDerivedFrom(Type baseType)
        {
            return new ExceptionsThrownMustBeDerivedFromConventionSpecification(baseType);
        }

        public static MustInstantiatePropertiesOfSpecifiedTypeInDefaultConstructorConventionSpecification
            MustInstantiatePropertiesOfSpecifiedTypeInDefaultConstructor(Type propertyType)
        {
            return new MustInstantiatePropertiesOfSpecifiedTypeInDefaultConstructorConventionSpecification(propertyType);
        }
    }
}