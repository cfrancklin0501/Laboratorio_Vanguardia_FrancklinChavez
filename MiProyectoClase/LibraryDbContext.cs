using Microsoft.EntityFrameworkCore;

using BibliotecaMonolito. Models;

namespace BibliotecaMonoLito;

public class LibraryDbContext: DbContext

{
public LibraryDbContext (DbContextOptions<LibraryDbContext> options): base(options){}

public Dbset <Autor> Autores => Set<Autor>();
public Dbset <Libro> Autores => Set<Libro>();
}