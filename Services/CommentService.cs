using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        //public async Task<Comment> GetByIdAsync(int id) => await _commentRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<Comment>> GetAllAsync() => await _commentRepository.GetAllAsync();

        //public async Task AddAsync(Comment comment)
        //{
        //    await _commentRepository.AddAsync(comment);
        //    //await _commentRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(Comment comment)
        //{
        //    await _commentRepository.UpdateAsync(comment);
        //    //await _commentRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _commentRepository.DeleteAsync(id);
        //    //await _commentRepository.SaveChangesAsync();
        //}
    }
}
