Feature: dishwasherreminders

A short summary of the feature



@tag1
Scenario: Dont Prompt again that dishwasher is done if last prompt was within the last 60 minutes
	Given The dishwasher is complete
	And I have not acknowledge unloading it
	And The last reminder was more than 60 minutes ago
	And it was after 7 AM
	When there is motion in the kitchen
	Then my smart speaker announces it's done and prompts me if it has been unloaded and stores the acknowledgement.a

Scenario: no announcements during quiet time
   Given it is before 5 AM
   When there is motion in the kitchen
   Then there is no annoucement