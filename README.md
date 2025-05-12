# Inventory Management System

A WinForms desktop application for managing product inventory with SQLite persistence.  
Add, edit, delete products; adjust stock levels; search and filter; export CSV; and generate sales/value reports.

---

## Features

- **Product CRUD**  
  - Add new products (ID auto-generated, Name, Category, Quantity, Price, Supplier)  
  - Edit existing product details via “Add Row” form  
  - Delete selected product rows  

- **Stock Adjustment**  
  - Increase or decrease stock for a selected product or by entering its ID  
  - Quantity updates only if valid (e.g. can’t remove more than in stock)  

- **Search & Filter**  
  - Live search by any column (Name, Category, Supplier, etc.)  
  - Select which field to search via dropdown  

- **Data Display**  
  - Inventory table in a `DataGridView`  
  - Color-coded Quantity column (low stock in pink, high stock in teal)  

- **Data Export**  
  - Export current inventory view to CSV via Save File dialog  
  - Generate a sales report (totals and per-ID “Removed” counts) with CSV export  

- **Action Logging**  
  - All Create/Update/Delete actions logged to `log.txt` with timestamps  

---

## Requirements

- **.NET Framework** (or .NET Core) with WinForms support  
- **System.Data.SQLite** NuGet package  
- Windows OS  

---

## Installation & Running

1. **Clone or download** this repository.  
2. **Open** the solution in Visual Studio.  
3. **Restore NuGet packages** (Tools → NuGet Package Manager → Restore).  
4. **Build** the solution.  
5. **Run** the application (F5 or Debug → Start Debugging).  

Alternatively, run the compiled EXE in the `bin\Debug` (or `bin\Release`) folder.

---

## Usage

1. **View Inventory**  
   - On launch, the existing `Product` table is loaded from `inventory.db`.  

2. **Add Product**  
   - Click **Add Row**, fill Name/Category/Quantity/Price/Supplier, click **Confirm**.  

3. **Remove Product**  
   - Select a row in the grid and click **Delete Row**.  

4. **Adjust Stock**  
   - Click **Add Stock** or **Remove Stock**, enter ID or select a row, enter amount, click **Add/Remove**.  

5. **Search**  
   - Type in the search box and choose the field from the dropdown — grid updates live.  

6. **Export CSV**  
   - Click **CSV Export**, choose save location — your inventory is saved as CSV.  

7. **Generate Report**  
   - Click **Gen Report**, choose save location — sales (“Removed” counts) and total inventory value are saved as CSV.  

---

## Configuration

- **Database**: `Files/inventory.db` is created/updated automatically next to the EXE.  
- **Log file**: `log.txt` is created in the working directory.  