/************************************
*			  LAB 6.1.5.18		    *	
*************************************/
#include <stdio.h>
#include <stdlib.h>

struct element
{
	int value;
	struct element *next;
};
int main(void)
{
	int values[10] = { 2, 4, 5, 6, 7, 8, 9, 1, 3, 0};
	//OBRIGADO, MARCO!
	struct element *eptr, *head = NULL, *aux;
	int i;
	for(i=0;i<10;i++)
	{
		if(head == NULL){												/* first element will be equal to NULL at the first iteraction */
			eptr = (struct element *) malloc(sizeof(struct element));	
			eptr -> value = values[i];
			eptr->next = NULL;											/* so allocate the last to NULL */
			head = eptr;												/* and the head will be kept as the first element! DO NOT CHANGE*/
		}
		else{															/* subsequent iteractions... */
			aux = head;													/* we use the auxiliar pointer to keep the value of the first iteraction (first element) */
			while(aux->next) aux = aux->next;							/* so if we want to add the subsequent values to the last position, we have to go there */
			eptr = (struct element *) malloc(sizeof(struct element));
			eptr -> value = values[i];
			eptr->next = NULL;											/*... points the next (of the last) to NULL */
			aux->next = eptr;											/* AND our auxiliar will have to be the newly added element, since it will always have to be the last one*/
		} 
	}
	printf("First 5 elements\n");
	aux = head;															/* always reset aux to first element to print the list */
	for(i=0;i<5;i++)
	{
		printf("%d\n",aux->value);
		aux = aux -> next;
	}
	aux = head;															/* always reset aux to first element to print the list */
	printf("First 7 elements\n");
	for(i=0;i<7;i++)
	{
		printf("%d\n",aux->value);
		aux = aux -> next;
	}
	free(eptr);
	printf("Memory is freed.");
	// DONE
	return 0;
}
/*$PAGE*/