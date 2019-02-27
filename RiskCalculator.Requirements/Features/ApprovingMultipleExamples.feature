Feature: Approving multiple examples
	
	in this reference example, approvaltests is being used to verify multiple examples
	And we're passing in the risk file name so that we can edit the first empty file
	by hand, and do it for each example at a time.
	
	The pattern here is to add in a column that is used to name the approval file.

Scenario Outline: Outline with lots of rows
	Given <qty> trades at <amount> in market <market>
	When I calculate the risk
	Then the risks are <risks>

Examples:
	| qty | amount | market  | risks |
	| 5   | 100    | market1 | market1-risk |
	| 30  | 20     | market2 | market2-risk |
