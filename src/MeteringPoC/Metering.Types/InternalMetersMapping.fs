﻿namespace Metering.Types

type InternalMetersMapping = // The mapping table used by the aggregator to translate an ApplicationInternalMeterName to the plan and dimension configured in Azure marketplace
    InternalMetersMapping of Map<ApplicationInternalMeterName, DimensionId>

module InternalMetersMapping =
    let value (InternalMetersMapping x) = x
    let create x = (InternalMetersMapping x)