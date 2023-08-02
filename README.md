# Mod 3 Week 5 Assessment

## Setup
* Fork and clone this repository.
* Open your forked repo in Visual Studio.
* Open the Package Manager Console and run `Update-Database`
  * If you run into any errors, reach out to an instructor!

## Exercise

Complete the following user stories:

```
As a User
When I visit "/golfbags"
Then I see the id, player, and capacity for all golf bags in the database
```

```
As a User
When I visit "/golfbags/2"
Then I see the Id, Player, Capacity, and Clubs that are in the golf bag specified in the route
```

```
As a User
When I visit "/golfbags"
Then I see a button next to each golf bag that says 'Delete'
```

```
As a User
When I visit "/golfbags"
And I click on a "Delete" Button
Then I am redirected to "/golfbags"
  And I can no longer see the bag that I deleted
```

```
As a User
When I visit "/golfbags/new"
Then I see a form to create a new GolfBag
  The form includes fields for Player and Capacity
```

```
As a User
When I visit "/golfbags/new"
And fill out and submit the form
Then I am redirected to the new golfbag's show page ("/golfbags/#")
```

```
As a User
When I visit "/golfbags/2/edit"
Then I see a form to create a new golf club for that bag.
```

```
As a User
When I visit "/golfbags/2/edit"
And I submit the form
Then I am redirected to "/golfbags/2"
  And I see the new club in that bag
```

## Rubric
This assessment is work 20 points; a score of 10 is considered passing. Points are based on the following:
* 2 points for setting up a controller class appropriately.
* For each user story above, you could earn 2 points.
