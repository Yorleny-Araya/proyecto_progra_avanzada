USE control_Asistencia
GO

/* Sede */
insert into Sede (sede) values ('PL1');
insert into Sede (sede) values ('PL2');
insert into Sede (sede) values ('PL3');
insert into Sede (sede) values ('PL4');

/*Rol*/
insert into Rol (rol) values ('AdminGeneral');
insert into Rol (rol) values ('AdminSede');

/*TipoAsistencia*/
insert into TipoAsistencia (tipoAsistencia) values ('Entrada');
insert into TipoAsistencia (tipoAsistencia) values ('Cafe Entrada');
insert into TipoAsistencia (tipoAsistencia) values ('Cafe Salida');
insert into TipoAsistencia (tipoAsistencia) values ('Almuerzo Entrada');
insert into TipoAsistencia (tipoAsistencia) values ('Almuerzo Salida');
insert into TipoAsistencia (tipoAsistencia) values ('Salida');

/*TipoAusencia*/
insert into TipoAusencia (tipoAusencia) values ('Vacaciones');
insert into TipoAusencia (tipoAusencia) values ('Ausencia');
insert into TipoAusencia (tipoAusencia) values ('Incapacidad');

/*Empleado*/
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Ulrike', 'Defond', 'Berceros', '8232-2179', 'uberceros0@dot.gov', 1, 1);
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Ethelda', 'Curryer', 'Sor', '8474-8416', 'esor1@pagesperso-orange.fr', 2, 2);
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Kylila', 'Courage', 'Palfreeman', '8944-2133', 'kpalfreeman2@naver.com', 3, 3);
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Cornelius', 'Sones', 'Houldin', '8994-3585', 'chouldin3@edublogs.org', 4, 1);
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Jeremy', 'Carslake', 'Olivie', '8349-2775', 'jolivie4@arizona.edu', 5, 2);
insert into Empleado (nombre, primerApellido, segundoApellido, telefono, correo, cantVacaciones, idSede) values ('Alvira', 'Sewall', 'Plaid', '8799-2500', 'aplaid5@nature.com', 6, 3);

/*Ausencia*/
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (1, '2021-12-13', '2021-12-15', 2, 'Vacaciones', 1);
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (2, '2021-05-23', '2021-05-23', 1, 'Permiso', 2);
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (2, '2021-10-31', '2021-10-31', 1, 'Permiso', 2);
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (2, '2021-10-11', '2021-10-11', 1, 'Cita Medica', 2);
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (3, '2021-11-25', '2022-11-28', 3, 'Enfermedad', 3);
insert into Ausencia (idEmpleado, fechaInicio, fechaFinal, cantDias, motivo, idTipoAusencia) values (3, '2021-02-01', '2021-02-15', 15, 'Covid19', 3);

/* Autenticación */
insert into Autenticacion (usuario, contrasena, estado, idEmpleado, idRol) values ('uldebe', '6WdXF6rqCb', 1, 1, 1);
insert into Autenticacion (usuario, contrasena, estado, idEmpleado, idRol) values ('etcuso', 'hRs3KWaR', 1, 2, 2);
insert into Autenticacion (usuario, contrasena, estado, idEmpleado, idRol) values ('kycopa', 'NyGoN4eX', 0, 3, 2);


