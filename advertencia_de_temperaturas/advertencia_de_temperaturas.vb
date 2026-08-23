Imports System
Module advertencia_de_temperaturas
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim lugares(9) As String
        Dim temperaturas(9) As Double
        Dim fechas(9) As String
        Dim horas(9) As String
        Dim temperaturasMinimas(9) As Double
        Dim temperaturasMaximas(9) As Double
        Dim niveles(9) As String
        Dim advertencias(9) As String
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------------//
        '--|menu_principal_advertencia_de_temperaturas|--//
        '------------------------------------------------//
        Do
            Console.WriteLine("menu principal advertencia de temperaturas")
            Console.WriteLine("1) Registrar temperatura")
            Console.WriteLine("2) Editar temperatura")
            Console.WriteLine("3) Listar temperaturas")
            Console.WriteLine("4) Buscar temperatura")
            Console.WriteLine("5) Eliminar temperatura")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '---------------------------//
                '--|registrar_temperatura|--//
                '---------------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas temperaturas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de temperatura")
                        Console.Write("Lugar: ")
                        lugares(cantidad) = Console.ReadLine()
                        Console.Write("Temperatura en °C: ")
                        temperaturas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Hora: ")
                        horas(cantidad) = Console.ReadLine()
                        Console.Write("Temperatura minima: ")
                        temperaturasMinimas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Temperatura maxima: ")
                        temperaturasMaximas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        If temperaturas(cantidad) < 10 Then
                            niveles(cantidad) = "Baja"
                            advertencias(cantidad) = "Temperatura baja"
                            estados(cantidad) = "Advertencia"
                        ElseIf temperaturas(cantidad) <= 30 Then
                            niveles(cantidad) = "Normal"
                            advertencias(cantidad) = "Temperatura dentro del rango normal"
                            estados(cantidad) = "Registrada"
                        ElseIf temperaturas(cantidad) <= 40 Then
                            niveles(cantidad) = "Advertencia"
                            advertencias(cantidad) = "Temperatura elevada"
                            estados(cantidad) = "Advertencia"
                        Else
                            niveles(cantidad) = "Critica"
                            advertencias(cantidad) = "Temperatura extremadamente elevada"
                            estados(cantidad) = "Critica"
                        End If
                        cantidad += 1
                        Console.WriteLine("Temperatura registrada correctamente.")
                        Console.WriteLine("Nivel: " & niveles(cantidad - 1) & " | Advertencia: " & advertencias(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                    End If
                '------------------------//
                '--|editar_temperatura|--//
                '------------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen temperaturas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Lugar: " & lugares(i) & " | Temperatura: " & temperaturas(i) & " °C | Fecha: " & fechas(i) & " | Hora: " & horas(i) & " | Minima: " & temperaturasMinimas(i) & " °C | Maxima: " & temperaturasMaximas(i) & " °C | Nivel: " & niveles(i) & " | Advertencia: " & advertencias(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la temperatura a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo lugar: ")
                            lugares(posicion) = Console.ReadLine()
                            Console.Write("Nueva temperatura en °C: ")
                            temperaturas(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nueva hora: ")
                            horas(posicion) = Console.ReadLine()
                            Console.Write("Nueva temperatura minima: ")
                            temperaturasMinimas(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva temperatura maxima: ")
                            temperaturasMaximas(posicion) = Convert.ToDouble(Console.ReadLine())
                            If temperaturas(posicion) < 10 Then
                                niveles(posicion) = "Baja"
                                advertencias(posicion) = "Temperatura baja"
                                estados(posicion) = "Advertencia"
                            ElseIf temperaturas(posicion) <= 30 Then
                                niveles(posicion) = "Normal"
                                advertencias(posicion) = "Temperatura dentro del rango normal"
                                estados(posicion) = "Registrada"
                            ElseIf temperaturas(posicion) <= 40 Then
                                niveles(posicion) = "Advertencia"
                                advertencias(posicion) = "Temperatura elevada"
                                estados(posicion) = "Advertencia"
                            Else
                                niveles(posicion) = "Critica"
                                advertencias(posicion) = "Temperatura extremadamente elevada"
                                estados(posicion) = "Critica"
                            End If
                            Console.WriteLine("Temperatura actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------//
                '--|listar_temperaturas|--//
                '-------------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen temperaturas registradas.")
                    Else
                        Console.WriteLine("lista de temperaturas")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Lugar: " & lugares(i) & " | Temperatura: " & temperaturas(i) & " °C | Fecha: " & fechas(i) & " | Hora: " & horas(i) & " | Minima: " & temperaturasMinimas(i) & " °C | Maxima: " & temperaturasMaximas(i) & " °C | Nivel: " & niveles(i) & " | Advertencia: " & advertencias(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '------------------------//
                '--|buscar_temperatura|--//
                '------------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen temperaturas registradas.")
                    Else
                        Console.Write("Ingrese el ID de la temperatura a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("temperatura encontrada")
                            Console.WriteLine("ID: " & ids(posicion) & " | Lugar: " & lugares(posicion) & " | Temperatura: " & temperaturas(posicion) & " °C | Fecha: " & fechas(posicion) & " | Hora: " & horas(posicion) & " | Minima: " & temperaturasMinimas(posicion) & " °C | Maxima: " & temperaturasMaximas(posicion) & " °C | Nivel: " & niveles(posicion) & " | Advertencia: " & advertencias(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------------//
                '--|eliminar_temperatura|--//
                '--------------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen temperaturas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Lugar: " & lugares(i) & " | Temperatura: " & temperaturas(i) & " °C | Fecha: " & fechas(i) & " | Hora: " & horas(i) & " | Minima: " & temperaturasMinimas(i) & " °C | Maxima: " & temperaturasMaximas(i) & " °C | Nivel: " & niveles(i) & " | Advertencia: " & advertencias(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la temperatura a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                lugares(i) = lugares(i + 1)
                                temperaturas(i) = temperaturas(i + 1)
                                fechas(i) = fechas(i + 1)
                                horas(i) = horas(i + 1)
                                temperaturasMinimas(i) = temperaturasMinimas(i + 1)
                                temperaturasMaximas(i) = temperaturasMaximas(i + 1)
                                niveles(i) = niveles(i + 1)
                                advertencias(i) = advertencias(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Temperatura eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen temperaturas registradas.")
                    Else
                        Dim bajas As Integer = 0
                        Dim normales As Integer = 0
                        Dim advertenciasCount As Integer = 0
                        Dim criticas As Integer = 0
                        Dim sumaTemperaturas As Double = 0
                        Dim temperaturaMayor As Double = temperaturas(0)
                        Dim temperaturaMenor As Double = temperaturas(0)
                        For i As Integer = 0 To cantidad - 1
                            sumaTemperaturas += temperaturas(i)
                            If temperaturas(i) > temperaturaMayor Then
                                temperaturaMayor = temperaturas(i)
                            End If
                            If temperaturas(i) < temperaturaMenor Then
                                temperaturaMenor = temperaturas(i)
                            End If
                            If niveles(i).ToLower() = "baja" Then
                                bajas += 1
                            ElseIf niveles(i).ToLower() = "normal" Then
                                normales += 1
                            ElseIf niveles(i).ToLower() = "advertencia" Then
                                advertenciasCount += 1
                            ElseIf niveles(i).ToLower() = "critica" Then
                                criticas += 1
                            End If
                        Next
                        Dim promedio As Double = sumaTemperaturas / cantidad
                        Console.WriteLine("resumen de advertencia de temperaturas")
                        Console.WriteLine("Mediciones: " & cantidad & " | Bajas: " & bajas & " | Normales: " & normales & " | Advertencias: " & advertenciasCount & " | Criticas: " & criticas & " | Temperatura mayor: " & temperaturaMayor & " °C | Temperatura menor: " & temperaturaMenor & " °C | Promedio: " & Math.Round(promedio, 2) & " °C")
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Advertencia de Temperaturas.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module