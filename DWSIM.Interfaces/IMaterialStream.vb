﻿Public Interface IMaterialStream

    Property SpecType As Enums.StreamSpec

    Property IsElectrolyteStream As Boolean

    Property ReferenceSolvent As String

    Property InputComposition As Dictionary(Of String, Double)

    Property CompositionBasis As Enums.CompositionBasis

    ReadOnly Property Phases() As Dictionary(Of Integer, IPhase)

    Property AtEquilibrium As Boolean

    Sub SetPhaseComposition(Vx As Array, phs As Integer)

    Sub SetOverallComposition(Vx As Array)

    Function Clone() As IMaterialStream

End Interface
