# cse210-ww-premierpro
ZAGADOU FRANCK 21-01-2025.

This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged as follows:

* `sandbox` - An empty project that you can use to play around with any concepts you like.
* `week01` - Starter projects for each of the C# Prep assignments.
*# Journal Program

* `week02` - Starter projects for each of the prove Developer projects.
  # Journal Program - C#

## Description

This program is designed to help users maintain a daily journal. The application allows users to add entries, display them, save entries to a file, and load entries from a file. Each entry includes a date, a random prompt, and the user's response.

## Features

1. **Write a new entry**: The user can respond to a random prompt and save their response along with the date.
2. **Display journal entries**: Display all journal entries, including the prompt, the response, and the date.
3. **Save entries**: Save all journal entries to a text file.
4. **Load entries from a file**: Load journal entries from a text file and add them to the journal.

## Prerequisites

Before running the program, make sure you have the following installed:

*`.NET SDK` (Version 6.0 or higher) - To compile and run the program in C#.
*`IDE` (Visual Studio Code, Visual Studio, or any C#-compatible IDE).
*`Git` (if using GitHub for version control).

## Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/barfils03/premierpro.git

# Project: YouTube Video Program

This project is an exercise for the CSE 210 course: Programming with Classes at Brigham Young University. The objective of this program is to create `Video` and `Comment` classes to store information about YouTube videos and their comments.

## Description

The program creates three videos, adds multiple comments to each of them, and then displays the information for each video, including the title, author, length, number of comments, and the comments themselves.

## Project Structure

- **Video.cs**: Contains the `Video` class, which manages video information and its comments.
- **Comment.cs**: Contains the `Comment` class, which manages comment information for videos.
- **Program.cs**: The main file where `Video` and `Comment` objects are created and displayed.

## Running the Program

To run the program, simply compile and execute the `Program.cs` file. It will display the following information for each video:

- Title
- Author
- Length
- Number of comments
- List of comments (including the commentator's name and the comment text)

### Example Output


# Online Ordering Program

This project demonstrates encapsulation in object-oriented programming, where we design a system to manage online product orders. The system includes classes for `Product`, `Customer`, `Address`, and `Order`, and allows calculation of the total cost, generation of packing labels, and shipping labels.

## Classes

- **Product**: Stores information about a product, including name, ID, price, and quantity. Calculates the total cost of a product.
- **Customer**: Stores customer information, including their name and address, and determines if the customer is in the USA.
- **Address**: Stores address details and determines if the address is in the USA.
- **Order**: Contains a list of products and a customer. Calculates the total order cost, and generates packing and shipping labels.

## Features

- **Total Order Cost Calculation**: The order's total cost includes the sum of product prices and shipping fees.
- **Packing Label**: Displays the name and ID of each product in the order.
- **Shipping Label**: Displays the customer’s name and address.

## Usage

The program creates two orders, each containing products and customer information. It then calculates the total cost of each order, generates packing and shipping labels, and displays the results.

## Example Output
