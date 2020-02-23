export async function handleResponse(response) {
  if (response.ok) return response.json();
  if (response.status !== 200 ) {
    const error = await response.text();
    throw new Error(error);
  }
  // throw new Error("Network response was not ok.");
}

// In a real app, would likely call an error logging service.
export function handleError(error) {
  throw error;
}
